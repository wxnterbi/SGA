using SGA.Domain.Entities.Configuration;
using SGA.Persistence.Context;
using SGA.Persistence.Interfaces;

namespace SGA.Persistence.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly SGABD _context;

        public UsuarioRepository(SGABD context)
        {
            _context = context;
        }

        public List<Usuario> GetAll()
        {
            return _context.Usuarios.ToList();
        }

        public Usuario GetById(int id)
        {
            return _context.Usuarios.Find(id);
        }

        public Usuario Add(Usuario usuario)
        {
            usuario.FechaCreacion = DateTime.Now;

            _context.Usuarios.Add(usuario);
            _context.SaveChanges();

            return usuario;
        }

        public Usuario Update(Usuario usuario)
        {
            var usuarioExistente = _context.Usuarios.Find(usuario.Id);

            if (usuarioExistente == null)
            {
                throw new Exception("Usuario no encontrado.");
            }

            usuarioExistente.IdentificadorInstitucional = usuario.IdentificadorInstitucional;
            usuarioExistente.Nombre = usuario.Nombre;
            usuarioExistente.TipoUsuario = usuario.TipoUsuario;
            usuarioExistente.Estado = usuario.Estado;
            usuarioExistente.FechaModificacion = DateTime.Now;

            _context.SaveChanges();

            return usuarioExistente;
        }

        public bool Delete(int id)
        {
            var usuario = _context.Usuarios.Find(id);

            if (usuario == null)
            {
                return false;
            }

            _context.Usuarios.Remove(usuario);
            _context.SaveChanges();

            return true;
        }
    }
}
