using Microsoft.AspNetCore.Mvc;
using SGA.Application.Dtos.RegistroAcceso;
using SGA.Application.Interfaces;

namespace SGA.Api.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RegistroAccesoController : ControllerBase
    {
        private readonly IRegistroAccesoService _registroAccesoService;

        public RegistroAccesoController(IRegistroAccesoService registroAccesoService)
        {
            _registroAccesoService = registroAccesoService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var registros = await _registroAccesoService.GetAllAsync();
            return Ok(registros);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            if (id <= 0)
                return BadRequest("El ID debe ser mayor que cero.");

            var registro = await _registroAccesoService.GetByIdAsync(id);

            if (registro == null)
                return NotFound("No se encontró el registro de acceso.");

            return Ok(registro);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] RegistroAccesoDto dto)
        {

            await _registroAccesoService.AddAsync(dto);

            return Ok("Registro de acceso creado correctamente.");
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] RegistroAccesoDto dto)
        {
            try
            {
                await _registroAccesoService.UpdateAsync(dto);
                return Ok("Registro de acceso actualizado correctamente.");

            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (id <= 0)
                return BadRequest("El ID debe ser mayor que cero.");

            try
            {

                await _registroAccesoService.DeleteAsync(id);
                return Ok("Registro de acceso eliminado correctamente.");
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}
