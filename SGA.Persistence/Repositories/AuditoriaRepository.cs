using Microsoft.EntityFrameworkCore;
using SGA.Persistence.Interfaces;

namespace SGA.Persistence.Repository
{
    public class AuditoriaRepository : IAuditoriaRepository
    {
        private readonly SgaDbContext _context;
        public AuditoriaRepository(SgaDbContext context) { _context = context; }

        public async Task AddAsync(Auditoria auditoria)
        {
            await _context.Auditorias.AddAsync(auditoria);
            await _context.SaveChangesAsync();
        }
        public async Task<IEnumerable<Auditoria>> GetAllAsync() => await _context.Auditorias.ToListAsync();
    }
}