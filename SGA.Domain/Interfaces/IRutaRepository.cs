using SGA.Domain.Entities.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SGA.Persistence.Interfaces
{
    public interface IRutaRepository
    {
        Task<List<Ruta>> GetAllAsync();
        Task<Ruta?> GetByIdAsync(int id);
        Task<Ruta> AddAsync(Ruta ruta);
        Task<Ruta> UpdateAsync(Ruta ruta);
        Task<bool> DeleteAsync(int id);
    }
}