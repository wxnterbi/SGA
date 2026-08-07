using SGA.Application.Base;
using SGA.Application.Dtos.Pago;
using SGA.Application.Dtos.TicketMensual;

namespace SGA.Application.Interfaces
{
    public interface ITicketMensualService : IBaseService<TicketMensualDto>
    {
        Task CrearDesdeCompraAsync(int usuarioId, int pagoId, ComprarTicketDto dto);
    }
}
