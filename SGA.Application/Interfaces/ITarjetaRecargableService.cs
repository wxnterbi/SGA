using SGA.Application.Base;
using SGA.Application.Dtos.TarjetaRecargable;

namespace SGA.Application.Interfaces
{
    public interface ITarjetaRecargableService : IBaseService<TarjetaRecargableDto>
    {
        Task<decimal> ObtenerSaldoAsync(int usuarioId);

        Task RecargarSaldoAsync(
            int usuarioId,
            decimal monto,
            string tipoPago);

        Task DescontarSaldoAsync(
            int usuarioId,
            decimal monto);

        Task<TarjetaRecargableDto?> GetByUsuarioIdAsync(
            int usuarioId);

        Task<TarjetaRecargableDto?> GetByMatriculaAsync(
            string matricula);
    }
}