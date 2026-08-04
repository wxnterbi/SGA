using SGA.Domain.Entities.Configuration;
using SGA.Persistence.Context;
using SGA.Persistence.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace SGA.Persistence.Repositories
{
    public class HorarioRepository : IHorarioRepository
    {
        private readonly SGABD _context;

        public HorarioRepository(SGABD context)
        {
            _context = context;
        }

        public async Task<List<Horario>> GetAllAsync()
        {
            return await _context.Horarios.ToListAsync();
        }

        public Horario GetById(int id)
        {
            return _context.Horarios.Find(id);
        }

        public Horario Add(Horario horario)
        {
            horario.FechaCreacion = DateTime.Now;

            _context.Horarios.Add(horario);
            _context.SaveChanges();

            return horario;
        }

        public Horario Update(Horario horario)
        {
            var horarioExistente = _context.Horarios.Find(horario.Id);

            if (horarioExistente == null)
                throw new Exception("Horario no encontrado.");

            horarioExistente.DiasOperacion = horario.DiasOperacion;
            horarioExistente.HoraSalida = horario.HoraSalida;
            horarioExistente.RutaId = horario.RutaId;
            horarioExistente.FechaModificacion = DateTime.Now;

            _context.SaveChanges();

            return horarioExistente;
        }

        public bool Delete(int id)
        {
            var horario = _context.Horarios.Find(id);

            if (horario == null)
                return false;

            _context.Horarios.Remove(horario);
            _context.SaveChanges();

            return true;
        }
    }
}
