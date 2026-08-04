using SGA.Domain.Entities.Configuration;

namespace SGA.Persistence.Interfaces
{
    public interface IConductorRepository
    {
        Task<List<Conductor>> GetAllAsync();
        Conductor GetById(int id);
        Conductor GetByCedula(string cedula);
        Conductor GetByTelefono(string telefono);
        Conductor Add(Conductor conductor);
        Conductor Update(Conductor conductor);
        bool Delete(int id);
    }
}
