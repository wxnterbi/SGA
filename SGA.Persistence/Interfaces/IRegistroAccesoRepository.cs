using SGA.Domain.Entities.Reservation;

namespace SGA.Persistence.Interfaces
{
    public interface IRegistroAccesoRepository
    {
        Task<RegistroAcceso> GetByIdAsync(int id);
        Task<IEnumerable<RegistroAcceso>> GetByViajeIdAsync(int viajeId);
        Task AddAsync(RegistroAcceso registro);
    }
}