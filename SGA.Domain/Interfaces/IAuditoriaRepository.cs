using SGA.Domain.Entities.Reservation;

namespace SGA.Persistence.Interfaces
{
    public interface IAuditoriaRepository
    {
        Task AddAsync(Auditoria auditoria);

        Task<IEnumerable<Auditoria>> GetAllAsync();

        Task<Auditoria?> GetByIdAsync(int id);
    }
}