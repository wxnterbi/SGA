using SGA.Application.Dtos.RegistroAcceso;

namespace SGA.Presentation.Desktop.Interfaces
{
    public interface IRegistroAccesoApiService
    {
        Task<List<RegistroAccesoDto>> GetAllAsync();

        Task<RegistroAccesoDto?> GetByIdAsync(int id);

        Task<List<RegistroAccesoDto>> GetByUsuarioIdAsync(int usuarioId);

        Task<bool> CreateAsync(CreateRegistroAccesoDto dto);

        Task<bool> UpdateAsync(UpdateRegistroAccesoDto dto);

        Task<bool> DeleteAsync(int id);

        Task<ResultadoAccesoDto?> ValidarMatriculaAsync(
            string matricula,
            int viajeId);
    }
}