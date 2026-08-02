using SGA.Application.Dtos.Usuario;
using SGA.Application.Interfaces;
using SGA.Domain.Entities.Configuration;
using SGA.Infrastructure.Notifications;
using SGA.Persistence.Interfaces;

namespace SGA.Application.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly INotificationService _notificationService;

        public UsuarioService(
            IUsuarioRepository usuarioRepository,
            INotificationService notificationService)
        {
            _usuarioRepository = usuarioRepository;
            _notificationService = notificationService;
        }

        public Task<IEnumerable<UsuarioDto>> GetAllAsync()
        {
            var usuarios = _usuarioRepository.GetAll();

            var resultado = usuarios.Select(u => new UsuarioDto
            {
                Id = u.Id,
                IdentificadorInstitucional = u.IdentificadorInstitucional,
                Nombre = u.Nombre,
                TipoUsuario = u.TipoUsuario,
                Estado = u.Estado
            });

            return Task.FromResult(resultado);
        }

        public Task<UsuarioDto?> GetByIdAsync(int id)
        {
            var usuario = _usuarioRepository.GetById(id);

            if (usuario == null)
                return Task.FromResult<UsuarioDto?>(null);

            return Task.FromResult<UsuarioDto?>(new UsuarioDto
            {
                Id = usuario.Id,
                IdentificadorInstitucional = usuario.IdentificadorInstitucional,
                Nombre = usuario.Nombre,
                TipoUsuario = usuario.TipoUsuario,
                Estado = usuario.Estado
            });
        }

        public async Task AddAsync(UsuarioDto dto)
        {
            Console.WriteLine("ENTRANDO A USUARIO SERVICE");

            var existeMatricula = _usuarioRepository.GetByIdentificador(dto.IdentificadorInstitucional);
            if (existeMatricula != null)
            {
                throw new InvalidOperationException($"La matrícula '{dto.IdentificadorInstitucional}' ya está registrada.");
            }
            var usuario = new Usuario
            {
                IdentificadorInstitucional = dto.IdentificadorInstitucional,
                Nombre = dto.Nombre,
                TipoUsuario = dto.TipoUsuario,
                Estado = dto.Estado
            };
            Console.WriteLine("ENTRANDO A USUARIO SERVICE");
            _usuarioRepository.Add(usuario);

            await _notificationService.SendNotificationAsync(
                "usuario@itla.edu.do",
                "Usuario registrado",
                "El usuario fue registrado correctamente en el sistema.");
        }

        public Task UpdateAsync(UsuarioDto dto)
        {
            var usuario = _usuarioRepository.GetById(dto.Id);

            var usuarioConMismaMatricula = _usuarioRepository.GetByIdentificador(dto.IdentificadorInstitucional);

            if (usuarioConMismaMatricula != null && usuarioConMismaMatricula.Id != dto.Id)
            {
                throw new InvalidOperationException($"La matrícula '{dto.IdentificadorInstitucional}' ya pertenece a otro usuario.");
            }

            if (usuario == null)
                throw new Exception("Usuario no encontrado.");

            usuario.IdentificadorInstitucional = dto.IdentificadorInstitucional;
            usuario.Nombre = dto.Nombre;
            usuario.TipoUsuario = dto.TipoUsuario;
            usuario.Estado = dto.Estado;

            _usuarioRepository.Update(usuario);

            return Task.CompletedTask;
        }

        public Task DeleteAsync(int id)
        {
            var eliminado = _usuarioRepository.Delete(id);

            if (!eliminado)
                throw new Exception("Usuario no encontrado.");

            return Task.CompletedTask;
        }
    }
}