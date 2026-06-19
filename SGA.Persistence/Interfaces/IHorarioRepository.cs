using SGA.Domain.Entities.Configuration;

namespace SGA.Persistence.Interfaces
{
    public interface IHorarioRepository
    {
        List<Horario> GetAll();
        Horario GetById(int id);
        Horario Add(Horario horario);
        Horario Update(Horario horario);
        bool Delete(int id);
    }
}
