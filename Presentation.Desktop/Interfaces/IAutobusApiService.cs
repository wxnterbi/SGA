using SGA.Application.Dtos.Autobus;

namespace SGA.Presentation.Desktop.Interfaces
{
    public interface IAutobusApiService
    {
        Task<List<AutobusDto>> GetAllAsync();

        Task<AutobusDto?> GetByIdAsync(int id);
    }
}