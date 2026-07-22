using SGA.Domain.Entities.Configuration;

namespace SGA.Persistence.Interfaces
{
    public interface IUsuarioRepository
    {
        List<Usuario> GetAll();

        Usuario GetById(int id);

        Usuario Add(Usuario usuario);

        Usuario Update(Usuario usuario);

        bool Delete(int id);
    }
}
