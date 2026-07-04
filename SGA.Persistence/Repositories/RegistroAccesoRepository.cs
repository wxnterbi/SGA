using Microsoft.EntityFrameworkCore;
using SGA.Persistence.Context;
using SGA.Persistence.Interfaces;
using SGA.Domain.Entities.Reservation;

namespace SGA.Persistence.Repository
{
    public class RegistroAccesoRepository : IRegistroAccesoRepository
    {
        private readonly SGABD _context;
        public RegistroAccesoRepository(SGABD context) { _context = context; }

        public async Task<RegistroAcceso> GetByIdAsync(int id) => await _context.RegistrosAcceso.FindAsync(id);
        public async Task<IEnumerable<RegistroAcceso>> GetAllAsync()
        {
            return await _context.RegistrosAcceso.ToListAsync();
        }
        public async Task<IEnumerable<RegistroAcceso>> GetByViajeIdAsync(int viajeId) =>
            await _context.RegistrosAcceso.Where(r => r.ViajeId == viajeId).ToListAsync();
        public async Task AddAsync(RegistroAcceso registro)
        {
            await _context.RegistrosAcceso.AddAsync(registro);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateAsync(RegistroAcceso registro)
        {
            _context.RegistrosAcceso.Update(registro);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(int id)
        {
            var registro = await _context.RegistrosAcceso.FindAsync(id);
            if (registro != null)
            {
                _context.RegistrosAcceso.Remove(registro);
                await _context.SaveChangesAsync();
            }
        }
    }
}