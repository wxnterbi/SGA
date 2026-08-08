using SGA.Application.Base;
using SGA.Application.Dtos.Auditoria;

namespace SGA.Application.Interfaces
{
    public interface IAuditoriaService
        : IBaseService<AuditoriaDto>
    {
        Task AddAsync(CreateAuditoriaDto dto);

        Task RegistrarAsync(
            string tipoAccion,
            string descripcion);
    }
}
