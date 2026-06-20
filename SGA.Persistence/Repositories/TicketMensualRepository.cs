using Microsoft.EntityFrameworkCore;
using SGA.Persistence.Context;
using SGA.Persistence.Interfaces;
using SGA.Domain.Entities.Reservation;

namespace SGA.Persistence.Repository
{
    public class TicketMensualRepository : ITicketMensualRepository
    {
        private readonly SGABD _context;
        public TicketMensualRepository(SGABD context) { _context = context; }

        public async Task<TicketMensual> GetByIdAsync(int id) => await _context.TicketsMensuales.FindAsync(id);
        public async Task<IEnumerable<TicketMensual>> GetByUsuarioIdAsync(int usuarioId) =>
            await _context.TicketsMensuales.Where(t => t.UsuarioId == usuarioId).ToListAsync();
        public async Task AddAsync(TicketMensual ticket)
        {
            await _context.TicketsMensuales.AddAsync(ticket);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateAsync(TicketMensual ticket)
        {
            _context.TicketsMensuales.Update(ticket);
            await _context.SaveChangesAsync();
        }
    }
}