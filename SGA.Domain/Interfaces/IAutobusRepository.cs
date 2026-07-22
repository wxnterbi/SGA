using SGA.Domain.Entities.Configuration;

namespace SGA.Persistence.Interfaces
{
    public interface IAutobusRepository
    {
        List<Autobus> GetAll();

        Autobus GetById(int id);

        Autobus Add(Autobus autobus);

        Autobus Update(Autobus autobus);

        bool Delete(int id);
    }
}
