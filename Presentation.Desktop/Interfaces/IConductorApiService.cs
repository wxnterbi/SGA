using SGA.Application.Dtos.Conductor;

namespace SGA.Presentation.Desktop.Interfaces
{
    public interface IConductorApiService
    {
        Task<List<ConductorDto>> GetAllAsync();

        Task<ConductorDto?> GetByIdAsync(int id);

        Task<bool> CreateAsync(ConductorDto conductor);

        Task<bool> UpdateAsync(ConductorDto conductor);

        Task<bool> DeleteAsync(int id);
    }
}