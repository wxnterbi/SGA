namespace SGA.Persistence.Interfaces
{
    public interface INotificacionRepository
    {
        Task<Notificacion> GetByIdAsync(int id);
        Task AddAsync(Notificacion notificacion);
        Task<IEnumerable<Notificacion>> GetByUsuarioIdAsync(int usuarioId);
    }
}