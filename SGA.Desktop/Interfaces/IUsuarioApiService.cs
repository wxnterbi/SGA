using SGA.Application.Dtos.Usuario;

namespace SGA.Desktop.Interfaces
{
    public interface IUsuarioApiService
    {
        Task<List<UsuarioDto>> GetAllAsync();

        Task<UsuarioDto?> GetByIdAsync(int id);

        Task<bool> CrearUsuarioAsync(CreateUsuarioDto dto);

        Task<bool> UpdateAsync(int id, UpdateUsuarioDto dto);

        Task<bool> DeleteAsync(int id);

        Task<bool> RecargarTarjetaAsync(int usuarioId, decimal monto);
    }
}