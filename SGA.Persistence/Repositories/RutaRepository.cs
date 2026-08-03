using SGA.Domain.Entities.Configuration;
using SGA.Persistence.Context;
using SGA.Persistence.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SGA.Persistence.Repositories
{
    public class RutaRepository : IRutaRepository
    {
        private readonly SGABD _context;

        public RutaRepository(SGABD context)
        {
            _context = context;
        }

        // 🟢 AHORA SÍ ES ASÍNCRONO REAL
        public async Task<List<Ruta>> GetAllAsync()
        {
            return await _context.Rutas.AsNoTracking().ToListAsync();
        }

        public async Task<Ruta?> GetByIdAsync(int id)
        {
            return await _context.Rutas.FindAsync(id);
        }

        public async Task<Ruta> AddAsync(Ruta ruta)
        {
            ruta.FechaCreacion = DateTime.Now;
            await _context.Rutas.AddAsync(ruta);
            await _context.SaveChangesAsync();
            return ruta;
        }

        public async Task<Ruta> UpdateAsync(Ruta ruta)
        {
            var rutaExistente = await _context.Rutas.FindAsync(ruta.Id);
            if (rutaExistente == null)
                throw new Exception("Ruta no encontrada.");

            rutaExistente.Nombre = ruta.Nombre;
            rutaExistente.Origen = ruta.Origen;
            rutaExistente.Destino = ruta.Destino;
            rutaExistente.FechaModificacion = DateTime.Now;

            await _context.SaveChangesAsync();
            return rutaExistente;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var ruta = await _context.Rutas.FindAsync(id);
            if (ruta == null)
                return false;

            _context.Rutas.Remove(ruta);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}