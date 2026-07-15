using SGA.Application.Interfaces;
using SGA.Application.Dtos.Incidencia;
using SGA.Persistence.Interfaces;
using SGA.Domain.Entities.Reservation;

namespace SGA.Application.Services
{
    public class IncidenciaService : IIncidenciaService
    {
        private readonly IIncidenciaRepository _incidenciaRepository;

        public IncidenciaService(IIncidenciaRepository incidenciaRepository)
        {
            _incidenciaRepository = incidenciaRepository ?? throw new ArgumentNullException(nameof(incidenciaRepository));
        }

        public async Task<IEnumerable<IncidenciaDto>> GetAllAsync()
        {
            return await Task.FromResult(Enumerable.Empty<IncidenciaDto>());
        }

        public async Task<IncidenciaDto?> GetByIdAsync(int id)
        {
            var i = await _incidenciaRepository.GetByIdAsync(id);
            if (i == null) return null;

            return new IncidenciaDto
            {
                Id = i.Id,
                ViajeId = i.ViajeId,
                ConductorId = i.ConductorId,
                Tipo = (int)i.Tipo,
                Descripcion = i.Descripcion,
                FechaHora = i.FechaHora
            };
        }

        public async Task AddAsync(IncidenciaDto dto)
        {
            var incidencia = new Incidencia
            {
                ViajeId = dto.ViajeId,
                ConductorId = dto.ConductorId,
                Tipo = (Domain.Enums.Reservation.TipoIncidencia)dto.Tipo,
                Descripcion = dto.Descripcion,
                FechaHora = dto.FechaHora
            };

            await _incidenciaRepository.AddAsync(incidencia);
        }

        public async Task UpdateAsync(IncidenciaDto dto)
        {
            await Task.CompletedTask;
        }

        public async Task DeleteAsync(int id)
        {
            await Task.CompletedTask;
        }
    }
}