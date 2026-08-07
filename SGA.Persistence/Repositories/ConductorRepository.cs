using Microsoft.EntityFrameworkCore;
using SGA.Domain.Entities.Configuration;
using SGA.Persistence.Context;
using SGA.Persistence.Interfaces;

namespace SGA.Persistence.Repositories
{
    public class ConductorRepository : IConductorRepository
    {
        private readonly SGABD _context;

        public ConductorRepository(SGABD context)
        {
            _context = context;
        }

        public async Task<List<Conductor>> GetAllAsync()
        {
            return await _context.Conductores
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<Conductor?> GetByIdAsync(int id)
        {
            return await _context.Conductores
                .FindAsync(id);
        }

        public async Task<Conductor?> GetByCedulaAsync(string cedula)
        {
            return await _context.Conductores
                .FirstOrDefaultAsync(c => c.Cedula == cedula);
        }

        public async Task<Conductor?> GetByTelefonoAsync(string telefono)
        {
            return await _context.Conductores
                .FirstOrDefaultAsync(c => c.Telefono == telefono);
        }

        public async Task<Conductor> AddAsync(Conductor conductor)
        {
            conductor.FechaCreacion = DateTime.Now;

            _context.Conductores.Add(conductor);

            await _context.SaveChangesAsync();

            return conductor;
        }

        public async Task<Conductor> UpdateAsync(Conductor conductor)
        {
            var existente = await _context.Conductores
                .FindAsync(conductor.Id);

            if (existente == null)
                throw new Exception("Conductor no encontrado.");

            existente.Nombre = conductor.Nombre;
            existente.Cedula = conductor.Cedula;
            existente.Licencia = conductor.Licencia;
            existente.Telefono = conductor.Telefono;
            existente.EstadoLaboral = conductor.EstadoLaboral;
            existente.FechaModificacion = DateTime.Now;

            await _context.SaveChangesAsync();

            return existente;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var conductor = await _context.Conductores
                .FindAsync(id);

            if (conductor == null)
                return false;

            _context.Conductores.Remove(conductor);

            await _context.SaveChangesAsync();

            return true;
        }
    }
}
