using SGA.Domain.Entities.Reservation;

namespace SGA.Persistence.Interfaces
{
    public interface IIncidenciaRepository
    {
        Task<Incidencia> GetByIdAsync(int id);
        Task<IEnumerable<Incidencia>> GetByViajeIdAsync(int viajeId);
        Task AddAsync(Incidencia incidencia);
    }
}