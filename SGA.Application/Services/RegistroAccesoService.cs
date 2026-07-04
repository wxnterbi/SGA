using SGA.Application.Dtos.RegistroAcceso;
using SGA.Application.Interfaces;
using SGA.Domain.Entities.Reservation;
using SGA.Persistence.Interfaces;

namespace SGA.Application.Services
{
    public class RegistroAccesoService : IRegistroAccesoService
    {
        private readonly IRegistroAccesoRepository _registroRepository;

        public RegistroAccesoService(IRegistroAccesoRepository registroRepository)
        {
            _registroRepository = registroRepository;
        }

        public async Task<IEnumerable<RegistroAccesoDto>> GetAllAsync()
        {
            var registros = await _registroRepository.GetAllAsync();

            return registros.Select(r => new RegistroAccesoDto
            {
                Id = r.Id,
                UsuarioId = r.UsuarioId,
                ViajeId = r.ViajeId,
                Permitido = r.Permitido,
                Motivo = r.Motivo,
                FechaHora = r.FechaHora
            });
        }

        public async Task<RegistroAccesoDto?> GetByIdAsync(int id)
        {
            var registro = await _registroRepository.GetByIdAsync(id);

            if (registro == null)
                return null;

            return new RegistroAccesoDto
            {
                Id = registro.Id,
                UsuarioId = registro.UsuarioId,
                ViajeId = registro.ViajeId,
                Permitido = registro.Permitido,
                Motivo = registro.Motivo,
                FechaHora = registro.FechaHora
            };
        }

        public async Task AddAsync(RegistroAccesoDto dto)
        {
            var registro = new RegistroAcceso
            {
                UsuarioId = dto.UsuarioId,
                ViajeId = dto.ViajeId,
                Permitido = dto.Permitido,
                Motivo = dto.Motivo,
                FechaHora = dto.FechaHora
            };

            await _registroRepository.AddAsync(registro);
        }

        public async Task UpdateAsync(RegistroAccesoDto dto)
        {
            var registro = await _registroRepository.GetByIdAsync(dto.Id);

            if (registro == null)
                throw new Exception("Registro de acceso no encontrado.");

            registro.UsuarioId = dto.UsuarioId;
            registro.ViajeId = dto.ViajeId;
            registro.Permitido = dto.Permitido;
            registro.Motivo = dto.Motivo;
            registro.FechaHora = dto.FechaHora;

            await _registroRepository.UpdateAsync(registro);
        }

        public async Task DeleteAsync(int id)
        {
            await _registroRepository.DeleteAsync(id);
        }
    }
}
