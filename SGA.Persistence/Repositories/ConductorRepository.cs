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

        public List<Conductor> GetAll()
        {
            return _context.Conductores.ToList();
        }

        public Conductor GetById(int id)
        {
            return _context.Conductores.Find(id);
        }

        public Conductor GetByCedula(string cedula)
        {
            return _context.Conductores.FirstOrDefault(c => c.Cedula == cedula);
        }

        public Conductor GetByTelefono(string telefono)
        {
            return _context.Conductores.FirstOrDefault(c => c.Telefono == telefono);
        }

        public Conductor Add(Conductor conductor)
        {
            conductor.FechaCreacion = DateTime.Now;

            _context.Conductores.Add(conductor);
            _context.SaveChanges();

            return conductor;
        }

        public Conductor Update(Conductor conductor)
        {
            var conductorExistente = _context.Conductores.Find(conductor.Id);

            if (conductorExistente == null)
                throw new Exception("Conductor no encontrado.");

            conductorExistente.Nombre = conductor.Nombre;
            conductorExistente.Cedula = conductor.Cedula; 
            conductorExistente.Licencia = conductor.Licencia;
            conductorExistente.Telefono = conductor.Telefono;
            conductorExistente.EstadoLaboral = conductor.EstadoLaboral;
            conductorExistente.FechaModificacion = DateTime.Now;

            _context.SaveChanges();

            return conductorExistente;
        }

        public bool Delete(int id)
        {
            var conductor = _context.Conductores.Find(id);

            if (conductor == null)
                return false;

            _context.Conductores.Remove(conductor);
            _context.SaveChanges();

            return true;
        }
    }
}
