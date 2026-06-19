using Microsoft.EntityFrameworkCore;
using SGA.Persistence.Interfaces;

namespace SGA.Persistence.Repositories
{
    public class ViajeRepository : IViajeRepository
    {
        private readonly SgaDbContext _context;

        public ViajeRepository(SgaDbContext context)
        {
            _context = context;
        }

        public async Task<Viaje> GetByIdAsync(int id)
        {
            return await _context.Viajes.FindAsync(id);
        }

        public async Task<IEnumerable<Viaje>> GetAllAsync()
        {
            return await _context.Viajes.ToListAsync();
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