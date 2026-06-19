using SGA.Domain.Entities.Configuration;
using SGA.Persistence.Context;
using SGA.Persistence.Interfaces;

namespace SGA.Persistence.Repositories
{
    public class RutaRepository : IRutaRepository
    {
        private readonly SGABD _context;

        public RutaRepository(SGABD context)
        {
            _context = context;
        }

        public List<Ruta> GetAll()
        {
            return _context.Rutas.ToList();
        }

        public Ruta GetById(int id)
        {
            return _context.Rutas.Find(id);
        }

        public Ruta Add(Ruta ruta)
        {
            ruta.FechaCreacion = DateTime.Now;

            _context.Rutas.Add(ruta);
            _context.SaveChanges();

            return ruta;
        }

        public Ruta Update(Ruta ruta)
        {
            var rutaExistente = _context.Rutas.Find(ruta.Id);

            if (rutaExistente == null)
                throw new Exception("Ruta no encontrada.");

            rutaExistente.Nombre = ruta.Nombre;
            rutaExistente.Origen = ruta.Origen;
            rutaExistente.Destino = ruta.Destino;
            rutaExistente.FechaModificacion = DateTime.Now;

            _context.SaveChanges();

            return rutaExistente;
        }

        public bool Delete(int id)
        {
            var ruta = _context.Rutas.Find(id);

            if (ruta == null)
                return false;

            _context.Rutas.Remove(ruta);
            _context.SaveChanges();

            return true;
        }
    }
}