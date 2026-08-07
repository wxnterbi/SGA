using Microsoft.EntityFrameworkCore;
using SGA.Domain.Entities.Reservation;
using SGA.Domain.Enums.Reservation;
using SGA.Persistence.Context;
using SGA.Persistence.Interfaces;

namespace SGA.Persistence.Repository
{
    public class TicketMensualRepository : ITicketMensualRepository
    {
        private readonly SGABD _context;
        public TicketMensualRepository(SGABD context) { _context = context; }

        public async Task<TicketMensual> GetByIdAsync(int id)
        {
            return await _context.TicketsMensuales
                .FirstOrDefaultAsync(t => t.Id == id);
        }
        public async Task<IEnumerable<TicketMensual>> GetAllAsync()
        {
            return await _context.TicketsMensuales
                .OrderByDescending(t => t.Id)
                .ToListAsync();
        }
        public async Task<IEnumerable<TicketMensual>> GetByUsuarioIdAsync(int usuarioId)
        {
            return await _context.TicketsMensuales
                .Where(t => t.UsuarioId == usuarioId)
                .OrderByDescending(t => t.Id)
                .ToListAsync();
        }

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
        public async Task DeleteAsync(int id)
        {
            var ticket = await _context.TicketsMensuales.FindAsync(id);

            if (ticket != null)
            {
                _context.TicketsMensuales.Remove(ticket);
                await _context.SaveChangesAsync();
            }
        }
        public async Task<TicketMensual?> GetActivoByUsuarioAsync(int usuarioId)
        {
            return await _context.TicketsMensuales
                .FirstOrDefaultAsync(x =>
                    x.UsuarioId == usuarioId &&
                    x.Estado == EstadoTicket.Activo &&
                    x.FechaFin >= DateTime.Today);
        }
    }
 }

