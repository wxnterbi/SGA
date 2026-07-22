using SGA.Domain.Entities.Configuration;

namespace SGA.Persistence.Interfaces
{
    public interface IRutaRepository
    {
        List<Ruta> GetAll();
        Ruta GetById(int id);
        Ruta Add(Ruta ruta);
        Ruta Update(Ruta ruta);
        bool Delete(int id);
    }
}
