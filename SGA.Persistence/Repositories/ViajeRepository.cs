using Microsoft.EntityFrameworkCore;
using SGA.Persistence.Context;
using SGA.Persistence.Interfaces;
using SGA.Domain.Entities.Reservation;

namespace SGA.Persistence.Repositories
{
    public class ViajeRepository : IViajeRepository
    {
        private readonly SGABD _context;

        public ViajeRepository(SGABD context)
        {
            _context = context;
        }

        public async Task<Viaje?> GetByIdAsync(int id)
        {
            return await _context.Viajes
                .Include(v => v.Ruta)
                .Include(v => v.Autobus)
                .Include(v => v.Conductor)
                .FirstOrDefaultAsync(v => v.Id == id);
        }

        public async Task<IEnumerable<Viaje>> GetAllAsync()
        {
            return await _context.Viajes
                .Include(v => v.Ruta)
                .Include(v => v.Autobus)
                .Include(v => v.Conductor)
                .ToListAsync();
        }

        public async Task AddAsync(Viaje viaje)
        {
            await _context.Viajes.AddAsync(viaje);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Viaje viaje)
        {
            _context.Viajes.Update(viaje);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var viaje = await GetByIdAsync(id);
            if (viaje != null)
            {
                _context.Viajes.Remove(viaje);
                await _context.SaveChangesAsync();
            }
        }
    }
}