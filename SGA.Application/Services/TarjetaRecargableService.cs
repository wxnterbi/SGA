using SGA.Application.BusinessRules;
using SGA.Application.Dtos.TarjetaRecargable;
using SGA.Application.Interfaces;
using SGA.Domain.Entities.Reservation;
using SGA.Domain.Enums.Reservation;
using SGA.Persistence.Interfaces;
using SGA.Persistence.Repository;

namespace SGA.Application.Services
{
    public class TarjetaRecargableService : ITarjetaRecargableService
    {
        private readonly ITarjetaRecargableRepository _tarjetaRepository;

        public TarjetaRecargableService(
            ITarjetaRecargableRepository tarjetaRepository)
        {
            _tarjetaRepository = tarjetaRepository;
        }

        public async Task<IEnumerable<TarjetaRecargableDto>> GetAllAsync()
        {
            var tarjetas = await _tarjetaRepository.GetAllAsync();

            return tarjetas.Select(t => new TarjetaRecargableDto
            {
                Id = t.Id,
                UsuarioId = t.UsuarioId,
                Saldo = t.Saldo,
                Estado = (int)t.Estado
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
                Saldo = tarjeta.Saldo,
                Estado = (int)tarjeta.Estado
            };
        }

        public async Task AddAsync(TarjetaRecargableDto dto)
        {

            var tarjeta = new TarjetaRecargable
            {
                UsuarioId = dto.UsuarioId,
                Saldo = dto.Saldo,
                Estado = (EstadoTarjeta)dto.Estado
            };

            await _tarjetaRepository.AddAsync(tarjeta);
        }

        public async Task UpdateAsync(TarjetaRecargableDto dto)
        {

            var tarjeta = await _tarjetaRepository.GetByIdAsync(dto.Id);

            if (tarjeta == null)
                throw new Exception("Tarjeta no encontrada.");

            tarjeta.UsuarioId = dto.UsuarioId;
            tarjeta.Saldo = dto.Saldo;
            tarjeta.Estado = (EstadoTarjeta)dto.Estado;

            await _tarjetaRepository.UpdateAsync(tarjeta);
        }

        public async Task DeleteAsync(int id)
        {
            var tarjeta = await _tarjetaRepository.GetByIdAsync(id);

            if (tarjeta == null)
                throw new Exception("No se encontró la tarjeta.");

            await _tarjetaRepository.DeleteAsync(id);
        }
    }
}
