using Microsoft.AspNetCore.Mvc;
using SGA.Application.Dtos.Usuario;
using SGA.Domain.Entities.Configuration;
using SGA.Persistence.Interfaces;

namespace SGA.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_usuarioRepository.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var usuario = _usuarioRepository.GetById(id);

            if (usuario == null)
            {
                return NotFound("Usuario no encontrado.");
            }

            return Ok(usuario);
        }

        [HttpPost]
        public IActionResult Post([FromBody] UsuarioDto dto)
        {
            var usuario = new Usuario
            {
                IdentificadorInstitucional = dto.IdentificadorInstitucional,
                Nombre = dto.Nombre,
                TipoUsuario = dto.TipoUsuario,
                Estado = dto.Estado
            };

            var nuevoUsuario = _usuarioRepository.Add(usuario);

            return Ok(nuevoUsuario);
        }

        [HttpPut]
        public IActionResult Put([FromBody] UsuarioDto dto)
        {
            var usuario = new Usuario
            {
                Id = dto.Id,
                IdentificadorInstitucional = dto.IdentificadorInstitucional,
                Nombre = dto.Nombre,
                TipoUsuario = dto.TipoUsuario,
                Estado = dto.Estado
            };

            var usuarioActualizado = _usuarioRepository.Update(usuario);

            return Ok(usuarioActualizado);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var eliminado = _usuarioRepository.Delete(id);

            if (!eliminado)
            {
                return NotFound("Usuario no encontrado.");
            }

            return Ok("Usuario eliminado correctamente.");
        }
    }
}
