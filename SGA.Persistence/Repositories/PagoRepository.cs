using Microsoft.EntityFrameworkCore;
using SGA.Persistence.Context;
using SGA.Persistence.Interfaces;
using SGA.Domain.Entities.Reservation;


namespace SGA.Persistence.Repository
{
    public class PagoRepository : IPagoRepository
    {
        private readonly SGABD _context;

        public PagoRepository(SGABD context) { _context = context; }

        public async Task<Pago> GetByIdAsync(int id) => await _context.Pagos.FindAsync(id);
        public async Task<IEnumerable<Pago>> GetAllAsync() => await _context.Pagos.ToListAsync();
        public async Task AddAsync(Pago pago)
        {
            await _context.Pagos.AddAsync(pago);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateAsync(Pago pago)
        {
            _context.Pagos.Update(pago);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(int id)
        {
            var pago = await _context.Pagos.FindAsync(id);

            if (pago != null)
            {
                _context.Pagos.Remove(pago);
                await _context.SaveChangesAsync();
            }
        }
    }
}