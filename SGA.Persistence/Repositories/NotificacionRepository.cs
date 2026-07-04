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
        public async Task<IEnumerable<Notificacion>> GetAllAsync()
        {
            return await _context.Notificaciones.ToListAsync();
        }
        public async Task AddAsync(Notificacion notificacion)
        {
            await _context.Notificaciones.AddAsync(notificacion);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateAsync(Notificacion notificacion)
        {
            _context.Notificaciones.Update(notificacion);
            await _context.SaveChangesAsync();
        }
        public async Task<IEnumerable<Notificacion>> GetByUsuarioIdAsync(int usuarioId)
        {
            return await _context.Notificaciones
                .Where(n => n.UsuarioId == usuarioId)
                .ToListAsync();
        }
        public async Task DeleteAsync(int id)
        {
            var notificacion = await _context.Notificaciones.FindAsync(id);

            if (notificacion != null)
            {
                _context.Notificaciones.Remove(notificacion);
                await _context.SaveChangesAsync();
            }
        }
    }
}
