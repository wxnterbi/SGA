using SGA.Application.Dtos.Viaje;
using SGA.Presentation.Desktop.Models;

namespace SGA.Presentation.Desktop.Interfaces
{
    public interface IViajeApiService
    {
        Task<List<ViajeDto>> GetAllAsync();

        Task<ViajeDto?> GetByIdAsync(int id);

        Task<ApiResponse> CreateAsync(ViajeDto viaje);

        Task<bool> UpdateAsync(ViajeDto viaje);

        Task<bool> DeleteAsync(int id);
    }
}