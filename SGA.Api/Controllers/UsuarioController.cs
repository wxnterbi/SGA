using Microsoft.AspNetCore.Mvc;
using SGA.Application.Dtos.Usuario;
using SGA.Application.Interfaces;

namespace SGA.Api.Desktop.Controllers
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
                return NotFound("Usuario no encontrado.");

            return Ok(usuario);
        }


        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateUsuarioDto dto)
        {
            try
            {
                await _usuarioService.AddAsync(dto);
                return Ok("Usuario registrado correctamente.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] UpdateUsuarioDto dto)
        {
            try
            {
                await _usuarioService.UpdateAsync(id, dto);

                return Ok("Usuario actualizado correctamente.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _usuarioService.DeleteAsync(id);

            return Ok("Usuario eliminado correctamente.");
        }
    }
}