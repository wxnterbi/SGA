using SGA.Application.Dtos.Ruta;

namespace SGA.Presentation.Desktop.Interfaces
{
    public interface IRutaApiService
    {
        Task<List<RutaDto>> GetAllAsync();

        Task<RutaDto?> GetByIdAsync(int id);

        Task<bool> CreateAsync(RutaDto ruta);

        Task<bool> UpdateAsync(RutaDto ruta);

        Task<bool> DeleteAsync(int id);
    }
}