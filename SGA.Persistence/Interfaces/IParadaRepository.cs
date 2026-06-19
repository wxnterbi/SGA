using SGA.Domain.Entities.Configuration;

namespace SGA.Persistence.Interfaces
{
    public interface IParadaRepository
    {
        List<Parada> GetAll();
        Parada GetById(int id);
        Parada Add(Parada parada);
        Parada Update(Parada parada);
        bool Delete(int id);
    }
}
