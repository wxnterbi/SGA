using SGA.Application.BusinessRules;
using SGA.Application.Dtos.TarjetaRecargable;
using SGA.Application.Interfaces;
using SGA.Domain.Entities.Reservation;
using SGA.Infrastructure.Notifications;
using SGA.Persistence.Interfaces;
using SGA.Persistence.Repository;

namespace SGA.Application.Services
{
    public class TarjetaRecargableService : ITarjetaRecargableService
    {
        private readonly ITarjetaRecargableRepository _tarjetaRepository;
        private readonly INotificationService _notificationService;

        public TarjetaRecargableService(
            ITarjetaRecargableRepository tarjetaRepository,
            INotificationService notificationService)
        {
            _tarjetaRepository = tarjetaRepository;
            _notificationService = notificationService;
        }

        public async Task<IEnumerable<TarjetaRecargableDto>> GetAllAsync()
        {
            var tarjetas = await _tarjetaRepository.GetAllAsync();

            return tarjetas.Select(t => new TarjetaRecargableDto
            {
                Id = t.Id,
                UsuarioId = t.UsuarioId,
                IdentificadorInstitucional = t.Usuario.IdentificadorInstitucional,
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
                IdentificadorInstitucional = tarjeta.Usuario.IdentificadorInstitucional,
                Saldo = tarjeta.Saldo
            };
        }

        public async Task AddAsync(TarjetaRecargableDto dto)
        {

            var tarjeta = new TarjetaRecargable
            {
                UsuarioId = dto.UsuarioId,
                Saldo = dto.Saldo,
            };

            await _tarjetaRepository.AddAsync(tarjeta);

            await _notificationService.SendNotificationAsync(
                  "estudiante@itla.edu.do",
                  "Tarjeta registrada",
                  "La tarjeta recargable fue registrada correctamente.");
        }

        public async Task UpdateAsync(TarjetaRecargableDto dto)
        {

            var tarjeta = await _tarjetaRepository.GetByIdAsync(dto.Id);

            if (tarjeta == null)
                throw new Exception("Tarjeta no encontrada.");

            tarjeta.UsuarioId = dto.UsuarioId;
            tarjeta.Saldo = dto.Saldo;

            await _tarjetaRepository.UpdateAsync(tarjeta);
        }

        public async Task DeleteAsync(int id)
        {
            var tarjeta = await _tarjetaRepository.GetByIdAsync(id);

            if (tarjeta == null)
                throw new Exception("No se encontró la tarjeta.");

            await _tarjetaRepository.DeleteAsync(id);
        }

        public async Task<decimal> ObtenerSaldoAsync(int usuarioId)
        {
            var tarjeta = await _tarjetaRepository.GetByUsuarioIdAsync(usuarioId);

            if (tarjeta == null)
                throw new Exception("El usuario no tiene una tarjeta recargable.");

            return tarjeta.Saldo;
        }

        public async Task RecargarSaldoAsync(int usuarioId, decimal monto)
        {
            if (monto <= 0)
                throw new Exception("El monto debe ser mayor que cero.");

            var tarjeta = await _tarjetaRepository.GetByUsuarioIdAsync(usuarioId);

            if (tarjeta == null)
                throw new Exception("El usuario no tiene una tarjeta recargable.");

            tarjeta.Saldo += monto;

            await _tarjetaRepository.UpdateAsync(tarjeta);

            await _notificationService.SendNotificationAsync(
                "estudiante@itla.edu.do",
                "Recarga realizada",
                $"Tu tarjeta fue recargada con RD$ {monto:N2}.");
        }

        public async Task DescontarSaldoAsync(int usuarioId, decimal monto)
        {
            var tarjeta = await _tarjetaRepository.GetByUsuarioIdAsync(usuarioId);

            if (tarjeta == null)
                throw new Exception("El usuario no tiene una tarjeta recargable.");

            if (tarjeta.Saldo < monto)
                throw new Exception("Saldo insuficiente.");

            tarjeta.Saldo -= monto;

            await _tarjetaRepository.UpdateAsync(tarjeta);
        }
        public async Task<TarjetaRecargableDto?> GetByUsuarioIdAsync(int usuarioId)
        {
            var tarjeta = await _tarjetaRepository.GetByUsuarioIdAsync(usuarioId);

            if (tarjeta == null)
                return null;

            return new TarjetaRecargableDto
            {
                Id = tarjeta.Id,
                UsuarioId = tarjeta.UsuarioId,
                IdentificadorInstitucional = tarjeta.Usuario.IdentificadorInstitucional,
                Saldo = tarjeta.Saldo
            };
        }
    }
}
