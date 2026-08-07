using SGA.Application.Dtos.Incidencia;

namespace SGA.Presentation.Desktop.Interfaces
{
    public interface IIncidenciaApiService
    {
        Task<List<IncidenciaDto>> GetAllAsync();

        Task<IncidenciaDto?> GetByIdAsync(int id);

        Task<bool> CreateAsync(IncidenciaDto incidencia);

        Task<bool> UpdateAsync(IncidenciaDto incidencia);

        Task<bool> DeleteAsync(int id);
    }
}
