using SGA.Application.Dtos.Ruta;

namespace SGA.Presentation.Desktop.Interfaces
{
    public interface IRutaApiService
    {
        Task<List<RutaDto>> GetAllAsync();

        Task<RutaDto?> GetByIdAsync(int id);
    }
}