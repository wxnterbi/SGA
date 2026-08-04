using SGA.Domain.Entities.Configuration;

namespace SGA.Persistence.Interfaces
{
    public interface IAutobusRepository
    {
        Task<List<Autobus>> GetAllAsync();

        Autobus GetById(int id);

        Autobus Add(Autobus autobus);

        Autobus Update(Autobus autobus);

        bool Delete(int id);

        Task<bool> ExistePlacaAsync(string placa, int idExcluir = 0);
    }
}
