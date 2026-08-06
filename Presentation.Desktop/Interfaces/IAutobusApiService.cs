using SGA.Application.Dtos.Autobus;
using SGA.Presentation.Desktop.Models;

namespace SGA.Presentation.Desktop.Interfaces
{
    public interface IAutobusApiService
    {
        Task<List<AutobusDto>> GetAllAsync();

        Task<AutobusDto?> GetByIdAsync(int id);

        Task<ApiResponse> CreateAsync(AutobusDto autobus);

        Task<ApiResponse> UpdateAsync(AutobusDto autobus);

        Task<ApiResponse> DeleteAsync(int id);
    }
}