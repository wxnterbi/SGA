using SGA.Web.Models.RegistroAcceso;

namespace SGA.Web.Interfaces.RegistroAcceso
{
    public interface IRegistroAccesoApiService
    {
        Task<List<RegistroAccesoViewModel>> GetAllAsync();

        Task<RegistroAccesoViewModel?> GetByIdAsync(int id);

        Task<List<RegistroAccesoViewModel>> GetByUsuarioIdAsync(int usuarioId);

        Task<bool> CreateAsync(RegistroAccesoViewModel registro);

        Task<bool> UpdateAsync(RegistroAccesoViewModel registro);

        Task<bool> DeleteAsync(int id);
    }
}
