using Microsoft.AspNetCore.Mvc;
using SGA.Application.Dtos.Ruta;
using SGA.Application.Interfaces;

namespace SGA.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RutaController : ControllerBase
    {
        private readonly IRutaService _rutaService;

        public RutaController(IRutaService rutaService)
        {
            _rutaService = rutaService;
        }


        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var rutas = await _rutaService.GetAllAsync();

            return Ok(rutas);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            if (id <= 0)
                return BadRequest("El ID debe ser mayor que cero.");

            var ruta = await _rutaService.GetByIdAsync(id);

            if (ruta == null)
                return NotFound("No se encontró la ruta.");

            return Ok(ruta);
        }


        [HttpPost]
        public async Task<IActionResult> Post([FromBody] RutaDto dto)
        {
            await _rutaService.AddAsync(dto);

            return Ok("Ruta registrada correctamente.");
        }


        [HttpPut]
        public async Task<IActionResult> Put([FromBody] RutaDto dto)
        {
            await _rutaService.UpdateAsync(dto);

            return Ok("Ruta actualizada correctamente.");
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (id <= 0)
                return BadRequest("El ID de la ruta debe ser mayor que cero.");

            try
            {
                await _rutaService.DeleteAsync(id);

                return Ok("Ruta eliminada correctamente.");
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}