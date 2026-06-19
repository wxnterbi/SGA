using SGA.Domain.Entities.Configuration;
using SGA.Persistence.Context;
using SGA.Persistence.Interfaces;

namespace SGA.Persistence.Repositories
{
    public class ParadaRepository : IParadaRepository
    {
        private readonly SGABD _context;

        public ParadaRepository(SGABD context)
        {
            _context = context;
        }

        public List<Parada> GetAll()
        {
            return _context.Paradas.ToList();
        }

        public Parada GetById(int id)
        {
            return _context.Paradas.Find(id);
        }

        public Parada Add(Parada parada)
        {
            parada.FechaCreacion = DateTime.Now;

            _context.Paradas.Add(parada);
            _context.SaveChanges();

            return parada;
        }

        public Parada Update(Parada parada)
        {
            var paradaExistente = _context.Paradas.Find(parada.Id);

            if (paradaExistente == null)
                throw new Exception("Parada no encontrada.");

            paradaExistente.Nombre = parada.Nombre;
            paradaExistente.Ubicacion = parada.Ubicacion;
            paradaExistente.Orden = parada.Orden;
            paradaExistente.FechaModificacion = DateTime.Now;

            _context.SaveChanges();

            return paradaExistente;
        }

        public bool Delete(int id)
        {
            var parada = _context.Paradas.Find(id);

            if (parada == null)
                return false;

            _context.Paradas.Remove(parada);
            _context.SaveChanges();

            return true;
        }
    }
}
