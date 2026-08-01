using SGA.Application.Dtos.Incidencia;
using SGA.Application.Interfaces;
using SGA.Domain.Entities.Reservation;
using SGA.Domain.Enums.Reservation;
using SGA.Infrastructure.Notifications;
using SGA.Persistence.Interfaces;

namespace SGA.Application.Services
{
    public class IncidenciaService : IIncidenciaService
    {
        private readonly IIncidenciaRepository _incidenciaRepository;
        private readonly INotificationService _notificationService;

        public IncidenciaService(
            IIncidenciaRepository incidenciaRepository,
            INotificationService notificationService)
        {
            _incidenciaRepository = incidenciaRepository ?? throw new ArgumentNullException(nameof(incidenciaRepository));
            _notificationService = notificationService;
        }

        public async Task<IEnumerable<IncidenciaDto>> GetAllAsync()
        {
            var incidencias = await _incidenciaRepository.GetAllAsync();

            return incidencias.Select(i => new IncidenciaDto
            {
                Id = i.Id,
                ViajeId = i.ViajeId,
                ConductorId = i.ConductorId,
                Tipo = (int)i.Tipo,
                Descripcion = i.Descripcion,
                FechaHora = i.FechaHora
            });
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
                Tipo = (TipoIncidencia)dto.Tipo,
                Descripcion = dto.Descripcion,
                FechaHora = dto.FechaHora == default ? DateTime.Now : dto.FechaHora
            };

            await _incidenciaRepository.AddAsync(incidencia);

            await _notificationService.SendNotificationAsync(
                "transporte@itla.edu.do",
                "Nueva Incidencia Reportada",
                "Incidencia registrada correctamente.");
        }

        public async Task UpdateAsync(IncidenciaDto dto)
        {
            var incidencia = await _incidenciaRepository.GetByIdAsync(dto.Id);
            if (incidencia != null)
            {
                incidencia.ViajeId = dto.ViajeId;
                incidencia.ConductorId = dto.ConductorId;
                incidencia.Tipo = (TipoIncidencia)dto.Tipo;
                incidencia.Descripcion = dto.Descripcion;
                incidencia.FechaHora = dto.FechaHora;

                await _incidenciaRepository.UpdateAsync(incidencia);
            }
        }

        public async Task DeleteAsync(int id)
        {
            var incidencia = await _incidenciaRepository.GetByIdAsync(id);
            if (incidencia != null)
            {
                await _incidenciaRepository.DeleteAsync(incidencia);
            }
        }
    }
}