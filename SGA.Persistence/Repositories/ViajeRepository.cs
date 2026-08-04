using Microsoft.EntityFrameworkCore;
using SGA.Domain.Entities.Reservation;
using SGA.Domain.Enums.Reservation;
using SGA.Persistence.Context;
using SGA.Persistence.Interfaces;

namespace SGA.Persistence.Repositories
{
    public class ViajeRepository : IViajeRepository
    {
        private readonly SGABD _context;

        public ViajeRepository(SGABD context)
        {
            _context = context;
        }

        public async Task<bool> ExisteConductorEnHorarioAsync(int conductorId, int horarioId, int viajeIdExcluir = 0)
        {
            return await _context.Viajes
                .AnyAsync(v => v.ConductorId == conductorId
                            && v.HorarioId == horarioId
                            && v.Id != viajeIdExcluir
                            && v.Estado != EstadoViaje.Cancelado
                            && v.Estado != EstadoViaje.Finalizado);
        }

        public async Task<bool> ExisteAutobusEnHorarioAsync(int autobusId, int horarioId, int viajeIdExcluir = 0)
        {
            return await _context.Viajes
                .AnyAsync(v => v.AutobusId == autobusId
                            && v.HorarioId == horarioId
                            && v.Id != viajeIdExcluir
                            && v.Estado != EstadoViaje.Cancelado
                            && v.Estado != EstadoViaje.Finalizado);
        }

        public async Task<Viaje?> GetByIdAsync(int id)
        {
            return await _context.Viajes
                .Include(v => v.Ruta)
                .Include(v => v.Autobus)
                .Include(v => v.Conductor)
                .Include(v => v.Horario)
                .FirstOrDefaultAsync(v => v.Id == id);
        }

        public async Task<IEnumerable<Viaje>> GetAllAsync()
        {
            return await _context.Viajes
                .Include(v => v.Ruta)
                .Include(v => v.Autobus)
                .Include(v => v.Conductor)
                .Include(v => v.Horario)
                .ToListAsync();
        }

        public async Task AddAsync(Viaje viaje)
        {
            await _context.Viajes.AddAsync(viaje);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Viaje viaje)
        {
            _context.Viajes.Update(viaje);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var viaje = await GetByIdAsync(id);
            if (viaje != null)
            {
                _context.Viajes.Remove(viaje);
                await _context.SaveChangesAsync();
            }
        }
    }
}