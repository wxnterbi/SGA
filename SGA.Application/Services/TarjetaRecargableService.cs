using SGA.Application.BusinessRules;
using SGA.Application.Dtos.TarjetaRecargable;
using SGA.Application.Interfaces;
using SGA.Domain.Entities.Reservation;
using SGA.Domain.Enums.Reservation;
using SGA.Infrastructure.Notifications;
using SGA.Persistence.Interfaces;

namespace SGA.Application.Services
{
    public class TarjetaRecargableService : ITarjetaRecargableService
    {
        private readonly ITarjetaRecargableRepository _tarjetaRepository;
        private readonly INotificationService _notificationService;
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IPagoRepository _pagoRepository;
        private readonly UsuarioRules _usuarioRules;
        private readonly IAuditoriaService _auditoriaService;

        public TarjetaRecargableService(
            ITarjetaRecargableRepository tarjetaRepository,
            INotificationService notificationService,
            IUsuarioRepository usuarioRepository,
            IPagoRepository pagoRepository,
            UsuarioRules usuarioRules,
            IAuditoriaService auditoriaService)
        {
            _tarjetaRepository = tarjetaRepository;
            _notificationService = notificationService;
            _usuarioRepository = usuarioRepository;
            _pagoRepository = pagoRepository;
            _usuarioRules = usuarioRules;
            _auditoriaService = auditoriaService;
        }

        public async Task<IEnumerable<TarjetaRecargableDto>> GetAllAsync()
        {
            var tarjetas = await _tarjetaRepository.GetAllAsync();

            return tarjetas.Select(t => new TarjetaRecargableDto
            {
                Id = t.Id,
                UsuarioId = t.UsuarioId,
                IdentificadorInstitucional =
                    t.Usuario.IdentificadorInstitucional,
                Saldo = t.Saldo
            });
        }

        public async Task<TarjetaRecargableDto?> GetByIdAsync(int id)
        {
            var tarjeta = await _tarjetaRepository.GetByIdAsync(id);

            if (tarjeta == null)
                return null;

            return new TarjetaRecargableDto
            {
                Id = tarjeta.Id,
                UsuarioId = tarjeta.UsuarioId,
                IdentificadorInstitucional =
                    tarjeta.Usuario.IdentificadorInstitucional,
                Saldo = tarjeta.Saldo
            };
        }

        public async Task AddAsync(TarjetaRecargableDto dto)
        {
            var usuario =
                _usuarioRepository.GetById(dto.UsuarioId);

            _usuarioRules.ValidarUsuarioRegistrado(usuario != null);

            var tarjeta = new TarjetaRecargable
            {
                UsuarioId = dto.UsuarioId,
                Saldo = dto.Saldo
            };

            await _tarjetaRepository.AddAsync(tarjeta);

            await _auditoriaService.RegistrarAsync(
                "CREAR",
                $"Se registró una tarjeta recargable para el usuario {dto.UsuarioId}.");

            await _notificationService.SendNotificationAsync(
                "estudiante@itla.edu.do",
                "Tarjeta registrada",
                "La tarjeta recargable fue registrada correctamente.");
        }

        public async Task UpdateAsync(TarjetaRecargableDto dto)
        {
            var tarjeta =
                await _tarjetaRepository.GetByIdAsync(dto.Id);

            if (tarjeta == null)
                throw new Exception("Tarjeta no encontrada.");

            var usuario =
                _usuarioRepository.GetById(dto.UsuarioId);

            _usuarioRules.ValidarUsuarioRegistrado(usuario != null);

            tarjeta.UsuarioId = dto.UsuarioId;
            tarjeta.Saldo = dto.Saldo;

            await _tarjetaRepository.UpdateAsync(tarjeta);

            await _auditoriaService.RegistrarAsync(
                "ACTUALIZAR",
                $"Se actualizó la tarjeta recargable ID {dto.Id}.");
        }

        public async Task DeleteAsync(int id)
        {
            var tarjeta =
                await _tarjetaRepository.GetByIdAsync(id);

            if (tarjeta == null)
                throw new Exception("No se encontró la tarjeta.");

            await _tarjetaRepository.DeleteAsync(id);

            await _auditoriaService.RegistrarAsync(
                "ELIMINAR",
                $"Se eliminó la tarjeta recargable ID {id}.");
        }

        public async Task<decimal> ObtenerSaldoAsync(int usuarioId)
        {
            var usuario =
                _usuarioRepository.GetById(usuarioId);

            _usuarioRules.ValidarUsuarioRegistrado(usuario != null);

            var tarjeta =
                await _tarjetaRepository.GetByUsuarioIdAsync(usuarioId);

            if (tarjeta == null)
                throw new Exception(
                    "El usuario no tiene una tarjeta recargable.");

            return tarjeta.Saldo;
        }

        public async Task RecargarSaldoAsync(
            int usuarioId,
            decimal monto,
            string tipoPago)
        {
            var usuario =
                _usuarioRepository.GetById(usuarioId);

            _usuarioRules.ValidarUsuarioRegistrado(usuario != null);

            if (monto <= 0)
                throw new Exception(
                    "El monto debe ser mayor que cero.");

            if (string.IsNullOrWhiteSpace(tipoPago))
                throw new Exception(
                    "Debe seleccionar un tipo de pago.");

            var tarjeta =
                await _tarjetaRepository.GetByUsuarioIdAsync(usuarioId);

            if (tarjeta == null)
                throw new Exception(
                    "El usuario no tiene una tarjeta recargable.");

            tarjeta.Saldo += monto;

            await _tarjetaRepository.UpdateAsync(tarjeta);

            var pago = new Pago
            {
                UsuarioId = usuarioId,
                Monto = monto,
                FechaPago = DateTime.Now,
                Modalidad = tipoPago,
                Concepto = ConceptoPago.Recarga,
                TipoTicket = null
            };

            await _pagoRepository.AddAsync(pago);

            await _auditoriaService.RegistrarAsync(
                "RECARGA",
                $"Se recargó la tarjeta del usuario {usuarioId} por RD$ {monto:N2}.");

            await _notificationService.SendNotificationAsync(
                "estudiante@itla.edu.do",
                "Recarga realizada",
                $"Tu tarjeta fue recargada con RD$ {monto:N2}.");
        }

        public async Task DescontarSaldoAsync(
            int usuarioId,
            decimal monto)
        {
            var usuario =
                _usuarioRepository.GetById(usuarioId);

            _usuarioRules.ValidarUsuarioRegistrado(usuario != null);

            if (monto <= 0)
                throw new Exception(
                    "El monto debe ser mayor que cero.");

            var tarjeta =
                await _tarjetaRepository.GetByUsuarioIdAsync(usuarioId);

            if (tarjeta == null)
                throw new Exception(
                    "El usuario no tiene una tarjeta recargable.");

            if (tarjeta.Saldo < monto)
                throw new Exception("Saldo insuficiente.");

            tarjeta.Saldo -= monto;

            await _tarjetaRepository.UpdateAsync(tarjeta);

            await _auditoriaService.RegistrarAsync(
                "DESCONTAR_SALDO",
                $"Se descontaron RD$ {monto:N2} de la tarjeta del usuario {usuarioId}.");
        }

        public async Task<TarjetaRecargableDto?> GetByUsuarioIdAsync(
            int usuarioId)
        {
            var usuario =
                _usuarioRepository.GetById(usuarioId);

            _usuarioRules.ValidarUsuarioRegistrado(usuario != null);

            var tarjeta =
                await _tarjetaRepository.GetByUsuarioIdAsync(usuarioId);

            if (tarjeta == null)
                return null;

            return new TarjetaRecargableDto
            {
                Id = tarjeta.Id,
                UsuarioId = tarjeta.UsuarioId,
                IdentificadorInstitucional =
                    tarjeta.Usuario.IdentificadorInstitucional,
                Saldo = tarjeta.Saldo
            };
        }

        public async Task<TarjetaRecargableDto?> GetByMatriculaAsync(
            string matricula)
        {
            var usuario =
                _usuarioRepository.GetByIdentificador(matricula);

            if (usuario == null)
                return null;

            var tarjeta =
                await _tarjetaRepository.GetByUsuarioIdAsync(usuario.Id);

            if (tarjeta == null)
                return null;

            return new TarjetaRecargableDto
            {
                Id = tarjeta.Id,
                UsuarioId = tarjeta.UsuarioId,
                IdentificadorInstitucional =
                    usuario.IdentificadorInstitucional,
                Saldo = tarjeta.Saldo
            };
        }
    }
}
