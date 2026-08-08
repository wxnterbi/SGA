using SGA.Application.Dtos.Auditoria;

namespace SGA.Presentation.Desktop.Interfaces
{
    public interface IAuditoriaApiService
    {
        Task<List<AuditoriaDto>> GetAllAsync();

        Task<AuditoriaDto?> GetByIdAsync(int id);
    }
}