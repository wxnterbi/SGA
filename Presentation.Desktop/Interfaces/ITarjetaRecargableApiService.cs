using SGA.Application.Dtos.TarjetaRecargable;

public interface ITarjetaRecargableApiService
{
    Task<TarjetaRecargableDto?> GetByMatriculaAsync(string matricula);

    Task<bool> RecargarSaldoAsync(RecargarSaldoDto dto);
}