using Microsoft.AspNetCore.Mvc;
using SGA.Application.Dtos.Incidencia;
using SGA.Application.Interfaces;

namespace SGA.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class IncidenciaController : ControllerBase
    {
        private readonly IIncidenciaService _incidenciaService;

        public IncidenciaController(IIncidenciaService incidenciaService)
        {
            _incidenciaService = incidenciaService;
        }


        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var incidencias = await _incidenciaService.GetAllAsync();

            return Ok(incidencias);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            if (id <= 0)
                return BadRequest("El ID debe ser mayor que cero.");

            var incidencia = await _incidenciaService.GetByIdAsync(id);

            if (incidencia == null)
                return NotFound("No se encontró la incidencia.");

            return Ok(incidencia);
        }


        [HttpPost]
        public async Task<IActionResult> Post([FromBody] IncidenciaDto dto)
        {
            await _incidenciaService.AddAsync(dto);

            return Ok("Incidencia registrada correctamente.");
        }


        [HttpPut]
        public async Task<IActionResult> Put([FromBody] IncidenciaDto dto)
        {
            await _incidenciaService.UpdateAsync(dto);

            return Ok("Incidencia actualizada correctamente.");
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (id <= 0)
                return BadRequest("El ID de la incidencia debe ser mayor que cero.");

            try
            {
                await _incidenciaService.DeleteAsync(id);

                return Ok("Incidencia eliminada correctamente.");
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}