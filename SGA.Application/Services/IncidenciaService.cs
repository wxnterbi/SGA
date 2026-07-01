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
            var incidencias = await _incidenciaRepository.GetAllAsync();
            return incidencias.Select(i => new IncidenciaDto
            {
                Id = i.Id,
                Descripcion = i.Descripcion,
                Fecha = i.Fecha,
                AutobusId = i.AutobusId,
                ConductorId = i.ConductorId,
                EstadoIncidenciaId = (int)i.TipoIncidencia
            });
        }

        public async Task<IncidenciaDto> GetByIdAsync(int id)
        {
            var i = await _incidenciaRepository.GetByIdAsync(id);
            if (i == null) return null;

            return new IncidenciaDto
            {
                Id = i.Id,
                Descripcion = i.Descripcion,
                Fecha = i.Fecha,
                AutobusId = i.AutobusId,
                ConductorId = i.ConductorId,
                EstadoIncidenciaId = (int)i.TipoIncidencia
            };
        }

        public async Task<bool> CreateAsync(CreateIncidenciaDto dto)
        {
            var incidencia = new Incidencia
            {
                Descripcion = dto.Descripcion,
                Fecha = dto.Fecha,
                AutobusId = dto.AutobusId,
                ConductorId = dto.ConductorId,
                TipoIncidencia = (Domain.Enums.Reservation.TipoIncidencia)dto.EstadoIncidenciaId
            };

            return await _incidenciaRepository.AddAsync(incidencia);
        }

        public async Task<bool> UpdateAsync(UpdateIncidenciaDto dto)
        {
            var incidencia = await _incidenciaRepository.GetByIdAsync(dto.Id);
            if (incidencia == null) return false;

            incidencia.Descripcion = dto.Descripcion;
            incidencia.TipoIncidencia = (Domain.Enums.Reservation.TipoIncidencia)dto.EstadoIncidenciaId;

            return await _incidenciaRepository.UpdateAsync(incidencia);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var incidencia = await _incidenciaRepository.GetByIdAsync(id);
            if (incidencia == null) return false;

            return await _incidenciaRepository.DeleteAsync(incidencia);
        }
    }
}