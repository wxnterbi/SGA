using Microsoft.EntityFrameworkCore;
using SGA.Domain.Entities.Configuration;
using SGA.Persistence.Context;
using SGA.Persistence.Interfaces;

namespace SGA.Persistence.Repositories
{
    public class AutobusRepository : IAutobusRepository
    {
        private readonly SGABD _context;

        public AutobusRepository(SGABD context)
        {
            _context = context;
        }

        public async Task<List<Autobus>> GetAllAsync()
        {
            return await _context.Autobuses.AsNoTracking().ToListAsync();
        }

        public Autobus GetById(int id)
        {
            return _context.Autobuses.Find(id);
        }

        public Autobus Add(Autobus autobus)
        {
            autobus.FechaCreacion = DateTime.Now;

            _context.Autobuses.Add(autobus);
            _context.SaveChanges();

            return autobus;
        }

        public Autobus Update(Autobus autobus)
        {
            var autobusExistente = _context.Autobuses.Find(autobus.Id);

            if (autobusExistente == null)
            {
                throw new Exception("Autobús no encontrado.");
            }

            autobusExistente.Placa = autobus.Placa;
            autobusExistente.CapacidadMaxima = autobus.CapacidadMaxima;
            autobusExistente.EstadoOperativo = autobus.EstadoOperativo;
            autobusExistente.FechaModificacion = DateTime.Now;

            _context.SaveChanges();

            return autobusExistente;
        }

        public bool Delete(int id)
        {
            var autobus = _context.Autobuses.Find(id);

            if (autobus == null)
            {
                return false;
            }

            _context.Autobuses.Remove(autobus);
            _context.SaveChanges();

            return true;
        }

        public async Task<bool> ExistePlacaAsync(string placa, int idExcluir = 0)
        {
            return await _context.Autobuses
                .AnyAsync(a => a.Placa.ToUpper() == placa.ToUpper() && a.Id != idExcluir);
        }
    }
}
