using SGA.Application.Dtos.Usuario;

namespace SGA.Presentation.Desktop.Interfaces
{
    public interface IUsuarioApiService
    {
        Task<List<UsuarioDto>> GetAllAsync();

        Task<UsuarioDto?> GetByIdAsync(int id);

        Task<bool> CreateAsync(CreateUsuarioDto usuario);

        Task<bool> UpdateAsync(int id, UpdateUsuarioDto usuario);

        Task<bool> DeleteAsync(int id);

        Task<LoginResponseDto?> LoginAsync(LoginUsuarioDto login);
    }
}