using SGA.Application.Dtos.Notificacion;
using SGA.Application.Interfaces;
using SGA.Domain.Entities.Reservation;
using SGA.Domain.Enums.Reservation;
using SGA.Persistence.Interfaces;
using SGA.Application.BusinessRules;

namespace SGA.Application.Services
{
    public class NotificacionService : INotificacionService
    {
        private readonly INotificacionRepository _notificacionRepository;
        private readonly NotificacionRules _notificacionRules;

        public NotificacionService(
            INotificacionRepository notificacionRepository,
            NotificacionRules notificacionRules)
        {
            _notificacionRepository = notificacionRepository;
            _notificacionRules = notificacionRules;
        }

        public async Task<IEnumerable<NotificacionDto>> GetAllAsync()
        {
            var notificaciones = await _notificacionRepository.GetAllAsync();

            return notificaciones.Select(n => new NotificacionDto
            {
                Id = n.Id,
                UsuarioId = n.UsuarioId,
                TipoEvento = (int)n.TipoEvento,
                Mensaje = n.Mensaje,
                FechaHora = n.FechaHora
            });
        }

        public async Task<NotificacionDto?> GetByIdAsync(int id)
        {
            var notificacion = await _notificacionRepository.GetByIdAsync(id);

            if (notificacion == null)
                return null;

            return new NotificacionDto
            {
                Id = notificacion.Id,
                UsuarioId = notificacion.UsuarioId,
                TipoEvento = (int)notificacion.TipoEvento,
                Mensaje = notificacion.Mensaje,
                FechaHora = notificacion.FechaHora
            };
        }

        public async Task AddAsync(NotificacionDto dto)
        {

            var notificacion = new Notificacion
            {
                UsuarioId = dto.UsuarioId,
                TipoEvento = (TipoEvento)dto.TipoEvento,
                Mensaje = dto.Mensaje,
                FechaHora = dto.FechaHora
            };

            await _notificacionRepository.AddAsync(notificacion);

            _notificacionRules.ValidarEnvioNotificacion(notificacion.Id > 0);
        }

        public async Task UpdateAsync(NotificacionDto dto)
        {

            var notificacion = await _notificacionRepository.GetByIdAsync(dto.Id);

            if (notificacion == null)
                throw new Exception("Notificación no encontrada.");

            notificacion.UsuarioId = dto.UsuarioId;
            notificacion.TipoEvento = (TipoEvento)dto.TipoEvento;
            notificacion.Mensaje = dto.Mensaje;
            notificacion.FechaHora = dto.FechaHora;

            await _notificacionRepository.UpdateAsync(notificacion);

            _notificacionRules.ValidarEnvioNotificacion(notificacion.Id > 0);
        }

        public async Task DeleteAsync(int id)
        {
            await _notificacionRepository.DeleteAsync(id);
        }
    }
}
