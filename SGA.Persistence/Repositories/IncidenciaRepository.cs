using Microsoft.EntityFrameworkCore;
using SGA.Persistence.Context;
using SGA.Persistence.Interfaces;
using SGA.Domain.Entities.Reservation;

namespace SGA.Persistence.Repository
{
    public class IncidenciaRepository : IIncidenciaRepository
    {
        private readonly SGABD _context;
        public IncidenciaRepository(SGABD context) { _context = context; }

        public async Task<Incidencia> GetByIdAsync(int id) => await _context.Incidencias.FindAsync(id);
        public async Task<IEnumerable<Incidencia>> GetByViajeIdAsync(int viajeId) =>
            await _context.Incidencias.Where(i => i.ViajeId == viajeId).ToListAsync();
        public async Task AddAsync(Incidencia incidencia)
        {
            await _context.Incidencias.AddAsync(incidencia);
            await _context.SaveChangesAsync();
        }
    }
}