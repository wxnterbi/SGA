using SGA.Application.Dtos.Pago;
using SGA.Application.Interfaces;
using SGA.Domain.Entities.Reservation;
using SGA.Persistence.Interfaces;
using SGA.Application.BusinessRules;

namespace SGA.Application.Services
{
    public class PagoService : IPagoService
    {
        private readonly IPagoRepository _pagoRepository;
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly UsuarioRules _usuarioRules;

        public PagoService(
            IPagoRepository pagoRepository,
            IUsuarioRepository usuarioRepository,
            UsuarioRules usuarioRules)
        {
            _pagoRepository = pagoRepository;
            _usuarioRepository = usuarioRepository;
            _usuarioRules = usuarioRules;
        }

        public async Task<IEnumerable<PagoDto>> GetAllAsync()
        {
            var pagos = await _pagoRepository.GetAllAsync();

            return pagos.Select(p => new PagoDto
            {
                Id = p.Id,
                UsuarioId = p.UsuarioId,
                Monto = p.Monto,
                FechaPago = p.FechaPago,
                Modalidad = p.Modalidad
            });
        }

        public async Task<PagoDto?> GetByIdAsync(int id)
        {
            var pago = await _pagoRepository.GetByIdAsync(id);

            if (pago == null)
                return null;

            return new PagoDto
            {
                Id = pago.Id,
                UsuarioId = pago.UsuarioId,
                Monto = pago.Monto,
                FechaPago = pago.FechaPago,
                Modalidad = pago.Modalidad
            };
        }

        public async Task AddAsync(PagoDto dto)
        {
            var usuario = _usuarioRepository.GetById(dto.UsuarioId);

            _usuarioRules.ValidarUsuarioRegistrado(usuario != null);

            var pago = new Pago
            {
                UsuarioId = dto.UsuarioId,
                Monto = dto.Monto,
                FechaPago = dto.FechaPago,
                Modalidad = dto.Modalidad
            };

            await _pagoRepository.AddAsync(pago);
        }

        public async Task UpdateAsync(PagoDto dto)
        {

            var pago = await _pagoRepository.GetByIdAsync(dto.Id);

            if (pago == null)
                throw new Exception("Pago no encontrado.");

            var usuario = _usuarioRepository.GetById(dto.UsuarioId);

            _usuarioRules.ValidarUsuarioRegistrado(usuario != null);

            pago.UsuarioId = dto.UsuarioId;
            pago.Monto = dto.Monto;
            pago.FechaPago = dto.FechaPago;
            pago.Modalidad = dto.Modalidad;

            await _pagoRepository.UpdateAsync(pago);
        }
        public async Task DeleteAsync(int id)
        {
            await _pagoRepository.DeleteAsync(id);
        }
    }
}
