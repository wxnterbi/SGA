using Microsoft.AspNetCore.Http;
using SGA.Application.Dtos.Auditoria;
using SGA.Application.Interfaces;
using SGA.Domain.Entities.Reservation;
using SGA.Infrastructure.Notifications;
using SGA.Persistence.Interfaces;
using System.Security.Claims;

namespace SGA.Application.Services
{
    public class AuditoriaService : IAuditoriaService
    {
        private readonly IAuditoriaRepository _auditoriaRepository;
        private readonly INotificationService _notificationService;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public AuditoriaService(
            IAuditoriaRepository auditoriaRepository,
            INotificationService notificationService,
            IHttpContextAccessor httpContextAccessor)
        {
            _auditoriaRepository = auditoriaRepository;
            _notificationService = notificationService;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<IEnumerable<AuditoriaDto>> GetAllAsync()
        {
            var auditorias =
                await _auditoriaRepository.GetAllAsync();

            return auditorias.Select(a => new AuditoriaDto
            {
                Id = a.Id,
                Actor = a.Actor,
                TipoAccion = a.TipoAccion,
                Descripcion = a.Descripcion,
                FechaHora = a.FechaHora
            });
        }

        public async Task<AuditoriaDto?> GetByIdAsync(int id)
        {
            var auditorias =
                await _auditoriaRepository.GetAllAsync();

            var auditoria =
                auditorias.FirstOrDefault(x => x.Id == id);

            if (auditoria == null)
                return null;

            return new AuditoriaDto
            {
                Id = auditoria.Id,
                Actor = auditoria.Actor,
                TipoAccion = auditoria.TipoAccion,
                Descripcion = auditoria.Descripcion,
                FechaHora = auditoria.FechaHora
            };
        }

        public async Task AddAsync(AuditoriaDto dto)
        {
            var auditoria = new Auditoria
            {
                Actor = dto.Actor,
                TipoAccion = dto.TipoAccion,
                Descripcion = dto.Descripcion,
                FechaHora = dto.FechaHora
            };

            await _auditoriaRepository.AddAsync(auditoria);
        }

        public async Task AddAsync(CreateAuditoriaDto dto)
        {
            var auditoria = new Auditoria
            {
                Actor = dto.Actor,
                TipoAccion = dto.TipoAccion,
                Descripcion = dto.Descripcion,
                FechaHora = DateTime.Now
            };

            await _auditoriaRepository.AddAsync(auditoria);

            await _notificationService.SendNotificationAsync(
                "administracion@itla.edu.do",
                "Auditoría registrada",
                "Se registró una nueva auditoría en el sistema.");
        }

        public async Task RegistrarAsync(
            string tipoAccion,
            string descripcion)
        {
            var actor = ObtenerActorActual();

            var auditoria = new Auditoria
            {
                Actor = actor,
                TipoAccion = tipoAccion,
                Descripcion = descripcion,
                FechaHora = DateTime.Now
            };

            await _auditoriaRepository.AddAsync(auditoria);
        }

        private string ObtenerActorActual()
        {
            var usuario = _httpContextAccessor.HttpContext?
                .User?
                .FindFirst(ClaimTypes.Name)?
                .Value;

            if (!string.IsNullOrWhiteSpace(usuario))
                return usuario;

            var nombre = _httpContextAccessor.HttpContext?
                .User?
                .FindFirst("Nombre")?
                .Value;

            if (!string.IsNullOrWhiteSpace(nombre))
                return nombre;

            var identificador = _httpContextAccessor.HttpContext?
                .User?
                .FindFirst("IdentificadorInstitucional")?
                .Value;

            if (!string.IsNullOrWhiteSpace(identificador))
                return identificador;

            return "Usuario no identificado";
        }

        public Task UpdateAsync(AuditoriaDto dto)
        {
            throw new NotSupportedException(
                "No está permitido modificar registros de auditoría.");
        }

        public Task DeleteAsync(int id)
        {
            throw new NotSupportedException(
                "No está permitido eliminar registros de auditoría.");
        }
    }
}