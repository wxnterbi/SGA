using Microsoft.EntityFrameworkCore;
using SGA.Persistence.Interfaces;

namespace SGA.Persistence.Repository
{

    public class TarjetaRecargableRepository : ITarjetaRecargableRepository
    {
        private readonly SgaDbContext _context;
        public TarjetaRecargableRepository(SgaDbContext context) { _context = context; }

        public async Task<TarjetaRecargable> GetByIdAsync(int id) => await _context.TarjetasRecargables.FindAsync(id);
        public async Task<TarjetaRecargable> GetByUsuarioIdAsync(int usuarioId) =>
            await _context.TarjetasRecargables.FirstOrDefaultAsync(t => t.UsuarioId == usuarioId);
        public async Task UpdateAsync(TarjetaRecargable tarjeta)
        {
            _context.TarjetasRecargables.Update(tarjeta);
            await _context.SaveChangesAsync();
        }
    }
}