using SGA.Application.Base;
using SGA.Application.Dtos.Pago;

namespace SGA.Application.Interfaces
{
    public interface IPagoService : IBaseService<PagoDto>
    {
        Task ComprarTicketAsync(ComprarTicketDto dto);
        Task<IEnumerable<PagoDto>> GetRecargasAsync();
    }
}
