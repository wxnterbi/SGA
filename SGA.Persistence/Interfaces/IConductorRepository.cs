using SGA.Domain.Entities.Configuration;

namespace SGA.Persistence.Interfaces
{
    public interface IConductorRepository
    {
        List<Conductor> GetAll();
        Conductor GetById(int id);
        Conductor Add(Conductor conductor);
        Conductor Update(Conductor conductor);
        bool Delete(int id);
    }
}
