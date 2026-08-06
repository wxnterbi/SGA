using SGA.Application.Dtos.Parada;

namespace SGA.Presentation.Desktop.Interfaces
{
    public interface IParadaApiService
    {
        Task<List<ParadaDto>> GetAllAsync();

        Task<ParadaDto?> GetByIdAsync(int id);

        Task<bool> CreateAsync(CreateParadaDto parada);

        Task<bool> UpdateAsync(UpdateParadaDto parada);

        Task<bool> DeleteAsync(int id);
    }
}