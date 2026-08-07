using SGA.Web.Models.TicketMensual;

namespace SGA.Web.Interfaces.TicketMensual
{
    public interface ITicketMensualApiService
    {
        Task<List<TicketMensualViewModel>> GetAllAsync();

        Task<TicketMensualViewModel?> GetByIdAsync(int id);

        Task<bool> CreateAsync(TicketMensualViewModel ticket);

        Task<bool> UpdateAsync(TicketMensualViewModel ticket);

        Task<bool> DeleteAsync(int id);
    }
}
