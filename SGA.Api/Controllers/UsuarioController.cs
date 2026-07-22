using Microsoft.AspNetCore.Mvc;
using SGA.Application.Dtos.Usuario;
using SGA.Domain.Entities.Configuration;
using SGA.Application.Interfaces;

namespace SGA.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var usuarios = await _usuarioService.GetAllAsync();

            return Ok(usuarios);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            if (id <= 0)
                return BadRequest("El ID debe ser mayor que cero.");

            var usuario = await _usuarioService.GetByIdAsync(id);

            if (usuario == null)
            {
                return NotFound("Usuario no encontrado.");
            }

            return Ok(usuario);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] UsuarioDto dto)
        {
            await _usuarioService.AddAsync(dto);

            return Ok("Usuario registrado correctamente.");
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] UsuarioDto dto)
        {
            await _usuarioService.UpdateAsync(dto);

            return Ok("Usuario actualizado correctamente.");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (id <= 0)
                return BadRequest("El ID debe ser mayor que cero.");

            await _usuarioService.DeleteAsync(id);

            return Ok("Usuario eliminado correctamente.");
        }
    }
}
