using SGA.Application.Dtos.Viaje;
using SGA.Application.Interfaces;
using SGA.Domain.Entities.Reservation;
using SGA.Persistence.Interfaces;

namespace SGA.Application.Services
{
    public class ViajeService : IViajeService
    {
        private readonly IViajeRepository _viajeRepository;

        public ViajeService(IViajeRepository viajeRepository)
        {
            _viajeRepository = viajeRepository;
        }

        public async Task<ViajeDto> GetByIdAsync(int id)
        {
            var viaje = await _viajeRepository.GetByIdAsync(id);
            if (viaje == null) return null;

            return new ViajeDto
            {
                Id = viaje.Id,
                RutaId = viaje.RutaId,
                HorarioId = viaje.HorarioId,
                AutobusId = viaje.AutobusId,
                ConductorId = viaje.ConductorId,
                Estado = viaje.Estado,
                HoraInicioReal = viaje.HoraInicioReal,
                HoraFinReal = viaje.HoraFinReal
            };
        }

        public async Task<IEnumerable<ViajeDto>> GetAllAsync()
        {
            var viajes = await _viajeRepository.GetAllAsync();
            return viajes.Select(viaje => new ViajeDto
            {
                Id = viaje.Id,
                RutaId = viaje.RutaId,
                HorarioId = viaje.HorarioId,
                AutobusId = viaje.AutobusId,
                ConductorId = viaje.ConductorId,
                Estado = viaje.Estado,
                HoraInicioReal = viaje.HoraInicioReal,
                HoraFinReal = viaje.HoraFinReal
            });
        }

        public async Task AddAsync(ViajeDto dto)
        {
            var viaje = new Viaje
            {
                RutaId = dto.RutaId,
                HorarioId = dto.HorarioId,
                AutobusId = dto.AutobusId,
                ConductorId = dto.ConductorId,
                Estado = dto.Estado,
                HoraInicioReal = dto.HoraInicioReal,
                HoraFinReal = dto.HoraFinReal
            };
            await _viajeRepository.AddAsync(viaje);
        }

        public async Task UpdateAsync(ViajeDto dto)
        {
            var viaje = await _viajeRepository.GetByIdAsync(dto.Id);
            if (viaje != null)
            {
                viaje.RutaId = dto.RutaId;
                viaje.HorarioId = dto.HorarioId;
                viaje.AutobusId = dto.AutobusId;
                viaje.ConductorId = dto.ConductorId;
                viaje.Estado = dto.Estado;
                viaje.HoraInicioReal = dto.HoraInicioReal;
                viaje.HoraFinReal = dto.HoraFinReal;

                await _viajeRepository.UpdateAsync(viaje);
            }
        }

        public async Task DeleteAsync(int id)
        {
            await _viajeRepository.DeleteAsync(id);
        }
    }
}