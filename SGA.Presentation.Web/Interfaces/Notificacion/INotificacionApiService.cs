using SGA.Web.Models.Notificacion;

namespace SGA.Web.Interfaces.Notificacion
{
    public interface INotificacionApiService
    {
        Task<List<NotificacionViewModel>> GetAllAsync();

        Task<NotificacionViewModel?> GetByIdAsync(int id);

        Task<bool> CreateAsync(NotificacionViewModel notificacion);

        Task<bool> UpdateAsync(NotificacionViewModel notificacion);

        Task<bool> DeleteAsync(int id);
    }
}
