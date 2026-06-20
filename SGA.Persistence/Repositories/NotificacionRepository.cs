using Microsoft.EntityFrameworkCore;
using SGA.Domain.Entities.Reservation;
using SGA.Persistence.Context;
using SGA.Persistence.Interfaces;

namespace SGA.Persistence.Repository
{
    public class NotificacionRepository : INotificacionRepository
    {
        private readonly SGABD _context;
        public NotificacionRepository(SGABD context) { _context = context; }

        public async Task<Notificacion> GetByIdAsync(int id) => await _context.Notificaciones.FindAsync(id);
        public async Task AddAsync(Notificacion notificacion)
        {
            await _context.Notificaciones.AddAsync(notificacion);
            await _context.SaveChangesAsync();
        }
        public async Task<IEnumerable<Notificacion>> GetByUsuarioIdAsync(int usuarioId) =>
            await _context.Notificaciones.Where(n => n.UsuarioId == usuarioId).ToListAsync();
    }
}
