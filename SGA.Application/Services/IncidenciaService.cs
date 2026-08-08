using SGA.Application.BusinessRules;
using SGA.Application.Dtos.Incidencia;
using SGA.Application.Dtos.Auditoria;
using SGA.Application.Interfaces;
using SGA.Application.Helpers;
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
        private readonly IncidenciaRules _incidenciaRules;
        private readonly IAuditoriaService _auditoriaService;

        public IncidenciaService(
            IIncidenciaRepository incidenciaRepository,
            INotificationService notificationService,
            IncidenciaRules incidenciaRules,
            IAuditoriaService auditoriaService)
        {
            _incidenciaRepository = incidenciaRepository
                ?? throw new ArgumentNullException(nameof(incidenciaRepository));

            _notificationService = notificationService
                ?? throw new ArgumentNullException(nameof(notificationService));

            _incidenciaRules = incidenciaRules
                ?? throw new ArgumentNullException(nameof(incidenciaRules));

            _auditoriaService = auditoriaService
                ?? throw new ArgumentNullException(nameof(auditoriaService));
        }

        public async Task<IEnumerable<IncidenciaDto>> GetAllAsync()
        {
            var incidencias =
                await _incidenciaRepository.GetAllAsync();

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
            var incidencia =
                await _incidenciaRepository.GetByIdAsync(id);

            if (incidencia == null)
                return null;

            return new IncidenciaDto
            {
                Id = incidencia.Id,
                ViajeId = incidencia.ViajeId,
                ConductorId = incidencia.ConductorId,
                Tipo = (int)incidencia.Tipo,
                Descripcion = incidencia.Descripcion,
                FechaHora = incidencia.FechaHora
            };
        }

        public async Task AddAsync(IncidenciaDto dto)
        {
            _incidenciaRules.ValidarRegistroIncidencia(
                dto.ViajeId,
                dto.ConductorId);

            var incidencia = new Incidencia
            {
                ViajeId = dto.ViajeId,
                ConductorId = dto.ConductorId,
                Tipo = (TipoIncidencia)dto.Tipo,
                Descripcion = dto.Descripcion,
                FechaHora = dto.FechaHora == default
                    ? DateTime.Now
                    : dto.FechaHora
            };

            await _incidenciaRepository.AddAsync(incidencia);

            await _notificationService.SendNotificationAsync(
                "transporte@itla.edu.do",
                "Nueva Incidencia Reportada",
                "Incidencia registrada correctamente.");

            await RegistrarAuditoria("Crear Incidencia",
                $"Se registró una incidencia para el viaje {dto.ViajeId}");
        }

        public async Task UpdateAsync(IncidenciaDto dto)
        {
            var incidencia =
                await _incidenciaRepository.GetByIdAsync(dto.Id);

            if (incidencia == null)
                throw new Exception("Incidencia no encontrada.");

            _incidenciaRules.ValidarRegistroIncidencia(
                dto.ViajeId,
                dto.ConductorId);

            incidencia.ViajeId = dto.ViajeId;
            incidencia.ConductorId = dto.ConductorId;
            incidencia.Tipo = (TipoIncidencia)dto.Tipo;
            incidencia.Descripcion = dto.Descripcion;
            incidencia.FechaHora = dto.FechaHora;

            await _incidenciaRepository.UpdateAsync(incidencia);

            await RegistrarAuditoria("Actualizar Incidencia",
                $"Se actualizó la incidencia ID {dto.Id}");
        }

        public async Task DeleteAsync(int id)
        {
            var incidencia =
                await _incidenciaRepository.GetByIdAsync(id);

            if (incidencia == null)
            {
                throw new InvalidOperationException(
                    "No se encontró la incidencia.");
            }

            await _incidenciaRepository.DeleteAsync(incidencia);

            await RegistrarAuditoria("Eliminar Incidencia",
                $"Se eliminó la incidencia ID {id}");
        }

        private async Task RegistrarAuditoria(string accion, string descripcion)
        {
            await _auditoriaService.AddAsync(new CreateAuditoriaDto
            {
                Actor = string.IsNullOrEmpty(SessionManager.Usuario)
                    ? "Sistema"
                    : SessionManager.Usuario,

                TipoAccion = accion,
                Descripcion = descripcion
            });
        }
    }
}