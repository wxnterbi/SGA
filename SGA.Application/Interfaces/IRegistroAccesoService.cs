using SGA.Application.Base;
using SGA.Application.Dtos.RegistroAcceso;

public interface IRegistroAccesoService : IBaseService<RegistroAccesoDto>
{
    Task RegistrarAccesoAsync(int usuarioId, int viajeId);

    Task<IEnumerable<RegistroAccesoDto>> GetByUsuarioIdAsync(int usuarioId);

    Task<ResultadoValidacionAccesoDto> ValidarAccesoAsync(
        ValidarAccesoDto dto);

    Task<ResultadoValidacionAccesoDto>
    ValidarPorMatriculaAsync(string matricula);

    Task<ResultadoAccesoDto> ValidarMatriculaAsync(
        string matricula,
        int viajeId);
}