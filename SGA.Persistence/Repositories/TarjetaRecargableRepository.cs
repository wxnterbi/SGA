using Microsoft.EntityFrameworkCore;
using SGA.Persistence.Context;
using SGA.Persistence.Interfaces;
using SGA.Domain.Entities.Reservation;

namespace SGA.Persistence.Repository
{

    public class TarjetaRecargableRepository : ITarjetaRecargableRepository
    {
        private readonly SGABD _context;
        public TarjetaRecargableRepository(SGABD context) { _context = context; }

        public async Task<TarjetaRecargable> GetByIdAsync(int id)
        {
            return await _context.TarjetasRecargables.FindAsync(id);
        }

        public async Task<IEnumerable<TarjetaRecargable>> GetAllAsync()
        {
            return await _context.TarjetasRecargables.ToListAsync();
        }
        public async Task<TarjetaRecargable> GetByUsuarioIdAsync(int usuarioId) =>
            await _context.TarjetasRecargables.FirstOrDefaultAsync(t => t.UsuarioId == usuarioId);
        public async Task AddAsync(TarjetaRecargable tarjeta)
        {
            await _context.TarjetasRecargables.AddAsync(tarjeta);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateAsync(TarjetaRecargable tarjeta)
        {
            _context.TarjetasRecargables.Update(tarjeta);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(int id)
        {
            var tarjeta = await _context.TarjetasRecargables.FindAsync(id);
            if (tarjeta != null)
            {
                _context.TarjetasRecargables.Remove(tarjeta);
                await _context.SaveChangesAsync();
            }
        }
    }
}