using Microsoft.AspNetCore.Mvc;
using SGA.Application.Dtos.Conductor;
using SGA.Application.Interfaces;

namespace SGA.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ConductorController : ControllerBase
    {
        private readonly IConductorService _conductorService;

        public ConductorController(IConductorService conductorService)
        {
            _conductorService = conductorService;
        }


        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var conductores = await _conductorService.GetAllAsync();

            return Ok(conductores);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            if (id <= 0)
                return BadRequest("El ID debe ser mayor que cero.");

            var conductor = await _conductorService.GetByIdAsync(id);

            if (conductor == null)
                return NotFound("No se encontró el conductor.");

            return Ok(conductor);
        }


        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ConductorDto dto)
        {
            await _conductorService.AddAsync(dto);

            return Ok("Conductor registrado correctamente.");
        }


        [HttpPut]
        public async Task<IActionResult> Put([FromBody] ConductorDto dto)
        {
            await _conductorService.UpdateAsync(dto);

            return Ok("Conductor actualizado correctamente.");
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (id <= 0)
                return BadRequest("El ID del conductor debe ser mayor que cero.");

            try
            {
                await _conductorService.DeleteAsync(id);

                return Ok("Conductor eliminado correctamente.");
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}