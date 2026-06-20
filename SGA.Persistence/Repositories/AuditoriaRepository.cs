using Microsoft.EntityFrameworkCore;
using SGA.Persistence.Interfaces;
using SGA.Domain.Entities.Reservation;
using SGA.Persistence.Context;

namespace SGA.Persistence.Repository
{
    public class AuditoriaRepository : IAuditoriaRepository
    {
        private readonly SGABD _context;
        public AuditoriaRepository(SGABD context) { _context = context; }

        public async Task AddAsync(Auditoria auditoria)
        {
            await _context.Auditorias.AddAsync(auditoria);
            await _context.SaveChangesAsync();
        }
        public async Task<IEnumerable<Auditoria>> GetAllAsync() => await _context.Auditorias.ToListAsync();
    }
}