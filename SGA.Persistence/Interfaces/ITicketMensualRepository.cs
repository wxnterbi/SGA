using SGA.Domain.Entities.Reservation;

namespace SGA.Persistence.Interfaces
{
    public interface ITicketMensualRepository
    {
        Task<TicketMensual> GetByIdAsync(int id);
        Task<IEnumerable<TicketMensual>> GetByUsuarioIdAsync(int usuarioId);
        Task AddAsync(TicketMensual ticket);
        Task UpdateAsync(TicketMensual ticket);
    }
}