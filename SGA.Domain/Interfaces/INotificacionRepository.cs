using SGA.Domain.Entities.Reservation;

namespace SGA.Persistence.Interfaces
{
    public interface INotificacionRepository
    {
        Task<Notificacion> GetByIdAsync(int id);
        Task<IEnumerable<Notificacion>> GetAllAsync();
        Task AddAsync(Notificacion notificacion);
        Task UpdateAsync(Notificacion notificacion);
        Task DeleteAsync(int id);
        Task<IEnumerable<Notificacion>> GetByUsuarioIdAsync(int usuarioId);
    }
}