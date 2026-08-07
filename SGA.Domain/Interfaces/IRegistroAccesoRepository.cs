using SGA.Domain.Entities.Reservation;

namespace SGA.Persistence.Interfaces
{
    public interface IRegistroAccesoRepository
    {
        Task<RegistroAcceso> GetByIdAsync(int id);
        Task<IEnumerable<RegistroAcceso>> GetAllAsync();
        Task<IEnumerable<RegistroAcceso>> GetByViajeIdAsync(int viajeId);
        Task<IEnumerable<RegistroAcceso>> GetByUsuarioIdAsync(int usuarioId);
        Task AddAsync(RegistroAcceso registro);
        Task UpdateAsync(RegistroAcceso registro);
        Task DeleteAsync(int id);
    }
}