using SGA.Application.Base;
using SGA.Application.Dtos.Usuario;

namespace SGA.Application.Interfaces
{
    public interface IUsuarioService
    {
        Task<IEnumerable<UsuarioDto>> GetAllAsync();

        Task<UsuarioDto?> GetByIdAsync(int id);

        Task AddAsync(CreateUsuarioDto dto);

        Task UpdateAsync(int id, UpdateUsuarioDto dto);

        Task DeleteAsync(int id);
    }
}
