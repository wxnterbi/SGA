using Microsoft.EntityFrameworkCore;
using SGA.Persistence.Interfaces;

namespace SGA.Persistence.Repository
{
    public class RegistroAccesoRepository : IRegistroAccesoRepository
    {
        private readonly SgaDbContext _context;
        public RegistroAccesoRepository(SgaDbContext context) { _context = context; }

        public async Task<RegistroAcceso> GetByIdAsync(int id) => await _context.RegistrosAcceso.FindAsync(id);
        public async Task<IEnumerable<RegistroAcceso>> GetByViajeIdAsync(int viajeId) =>
            await _context.RegistrosAcceso.Where(r => r.ViajeId == viajeId).ToListAsync();
        public async Task AddAsync(RegistroAcceso registro)
        {
            await _context.RegistrosAcceso.AddAsync(registro);
            await _context.SaveChangesAsync();
        }
    }
}