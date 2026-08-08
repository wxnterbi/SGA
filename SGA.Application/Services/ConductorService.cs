using SGA.Application.Dtos.Conductor;
using SGA.Application.Dtos.Auditoria;
using SGA.Application.Interfaces;
using SGA.Application.Helpers;
using SGA.Domain.Entities.Configuration;
using SGA.Domain.Enums.Configuration;
using SGA.Infrastructure.Notifications;
using SGA.Persistence.Interfaces;

namespace SGA.Application.Services
{
    public class ConductorService : IConductorService
    {
        private readonly IConductorRepository _conductorRepository;
        private readonly INotificationService _notificationService;
        private readonly IAuditoriaService _auditoriaService;

        public ConductorService(
            IConductorRepository conductorRepository,
            INotificationService notificationService,
            IAuditoriaService auditoriaService)
        {
            _conductorRepository = conductorRepository;
            _notificationService = notificationService;
            _auditoriaService = auditoriaService;
        }

        public async Task<IEnumerable<ConductorDto>> GetAllAsync()
        {
            var conductores = await _conductorRepository.GetAllAsync();

            return conductores.Select(c => new ConductorDto
            {
                Id = c.Id,
                Nombre = c.Nombre,
                Cedula = c.Cedula,
                Licencia = c.Licencia,
                Telefono = c.Telefono,
                EstadoConductorId = (int)c.EstadoLaboral
            });
        }

        public async Task<ConductorDto?> GetByIdAsync(int id)
        {
            var conductor = await _conductorRepository.GetByIdAsync(id);

            if (conductor == null)
                return null;

            return new ConductorDto
            {
                Id = conductor.Id,
                Nombre = conductor.Nombre,
                Cedula = conductor.Cedula,
                Licencia = conductor.Licencia,
                Telefono = conductor.Telefono,
                EstadoConductorId = (int)conductor.EstadoLaboral
            };
        }

        public async Task AddAsync(ConductorDto dto)
        {
            var existeCedula =
                await _conductorRepository.GetByCedulaAsync(dto.Cedula);

            if (existeCedula != null)
                throw new InvalidOperationException("CEDULA_DUPLICADA");

            var existeTelefono =
                await _conductorRepository.GetByTelefonoAsync(dto.Telefono);

            if (existeTelefono != null)
                throw new InvalidOperationException("TELEFONO_DUPLICADO");

            var conductor = new Conductor
            {
                Nombre = dto.Nombre,
                Cedula = dto.Cedula,
                Licencia = dto.Licencia,
                Telefono = dto.Telefono,
                EstadoLaboral = (EstadoLaboral)dto.EstadoConductorId
            };

            await _conductorRepository.AddAsync(conductor);

            await _notificationService.SendNotificationAsync(
                "conductor@itla.edu.do",
                "Conductor registrado",
                $"El conductor '{conductor.Nombre}' fue registrado correctamente.");


            await _auditoriaService.AddAsync(new CreateAuditoriaDto
            {
                Actor = string.IsNullOrEmpty(SessionManager.Usuario)
                    ? "Sistema"
                    : SessionManager.Usuario,

                TipoAccion = "Crear Conductor",

                Descripcion = $"Se creó el conductor {conductor.Nombre} (Cédula: {conductor.Cedula})"
            });
        }

        public async Task UpdateAsync(ConductorDto dto)
        {
            var conductor = await _conductorRepository.GetByIdAsync(dto.Id);

            if (conductor == null)
                throw new Exception("Conductor no encontrado.");

            var existeCedula =
                await _conductorRepository.GetByCedulaAsync(dto.Cedula);

            if (existeCedula != null && existeCedula.Id != dto.Id)
                throw new InvalidOperationException("CEDULA_DUPLICADA");

            var existeTelefono =
                await _conductorRepository.GetByTelefonoAsync(dto.Telefono);

            if (existeTelefono != null && existeTelefono.Id != dto.Id)
                throw new InvalidOperationException("TELEFONO_DUPLICADO");

            conductor.Nombre = dto.Nombre;
            conductor.Cedula = dto.Cedula;
            conductor.Licencia = dto.Licencia;
            conductor.Telefono = dto.Telefono;
            conductor.EstadoLaboral = (EstadoLaboral)dto.EstadoConductorId;

            await _conductorRepository.UpdateAsync(conductor);


            await _auditoriaService.AddAsync(new CreateAuditoriaDto
            {
                Actor = string.IsNullOrEmpty(SessionManager.Usuario)
                    ? "Sistema"
                    : SessionManager.Usuario,

                TipoAccion = "Actualizar Conductor",

                Descripcion = $"Se actualizó el conductor ID {dto.Id}"
            });
        }

        public async Task DeleteAsync(int id)
        {
            var eliminado = await _conductorRepository.DeleteAsync(id);

            if (!eliminado)
                throw new Exception("Conductor no encontrado.");


            await _auditoriaService.AddAsync(new CreateAuditoriaDto
            {
                Actor = string.IsNullOrEmpty(SessionManager.Usuario)
                    ? "Sistema"
                    : SessionManager.Usuario,

                TipoAccion = "Eliminar Conductor",

                Descripcion = $"Se eliminó el conductor ID {id}"
            });
        }
    }
}