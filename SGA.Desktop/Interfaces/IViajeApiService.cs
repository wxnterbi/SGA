using SGA.Application.Dtos.Viaje;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace SGA.Desktop.Interfaces.Viaje
{
    public interface IViajeApiService
    {
        Task<List<ViajeDto>> GetAllAsync();
        Task<ViajeDto?> GetByIdAsync(int id);
        Task<bool> CreateAsync(CreateViajeDto dto);
        Task<bool> UpdateAsync(int id, UpdateViajeDto dto);
        Task<bool> DeleteAsync(int id);
    }
}