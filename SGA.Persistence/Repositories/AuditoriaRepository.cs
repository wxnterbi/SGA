using Microsoft.EntityFrameworkCore;
using SGA.Domain.Entities.Reservation;
using SGA.Persistence.Context;
using SGA.Persistence.Interfaces;

namespace SGA.Persistence.Repository
{
    public class AuditoriaRepository : IAuditoriaRepository
    {
        private readonly SGABD _context;

        public AuditoriaRepository(SGABD context)
        {
            _context = context;
        }

        public async Task AddAsync(Auditoria auditoria)
        {
            await _context.Auditorias.AddAsync(auditoria);

            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Auditoria>> GetAllAsync()
        {
            return await _context.Auditorias
                .AsNoTracking()
                .OrderByDescending(a => a.FechaHora)
                .ToListAsync();
        }

        public async Task<Auditoria?> GetByIdAsync(int id)
        {
            return await _context.Auditorias
                .AsNoTracking()
                .FirstOrDefaultAsync(a => a.Id == id);
        }
    }
}