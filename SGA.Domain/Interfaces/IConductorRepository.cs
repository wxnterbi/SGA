using SGA.Domain.Entities.Configuration;

namespace SGA.Persistence.Interfaces
{
    public interface IConductorRepository
    {
        Task<List<Conductor>> GetAllAsync();

        Task<Conductor?> GetByIdAsync(int id);

        Task<Conductor?> GetByCedulaAsync(string cedula);

        Task<Conductor?> GetByTelefonoAsync(string telefono);

        Task<Conductor> AddAsync(Conductor conductor);

        Task<Conductor> UpdateAsync(Conductor conductor);

        Task<bool> DeleteAsync(int id);
    }
}
