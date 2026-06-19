using Microsoft.EntityFrameworkCore;
using SGA.Persistence.Interfaces;

namespace SGA.Persistence.Repository
{
    public class PagoRepository : IPagoRepository
    {
        private readonly SgaDbContext _context;

        public PagoRepository(SgaDbContext context) { _context = context; }

        public async Task<Pago> GetByIdAsync(int id) => await _context.Pagos.FindAsync(id);
        public async Task<IEnumerable<Pago>> GetAllAsync() => await _context.Pagos.ToListAsync();
        public async Task AddAsync(Pago pago)
        {
            await _context.Pagos.AddAsync(pago);
            await _context.SaveChangesAsync();
        }
    }
}