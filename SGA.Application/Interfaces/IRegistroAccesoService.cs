using SGA.Application.Base;
using SGA.Application.Dtos.RegistroAcceso;

namespace SGA.Application.Interfaces
{
    public interface IRegistroAccesoService : IBaseService<RegistroAccesoDto>
    {
        Task RegistrarAccesoAsync(int usuarioId, int viajeId);

        Task<IEnumerable<RegistroAccesoDto>> GetByUsuarioIdAsync(int usuarioId);
    }
}
