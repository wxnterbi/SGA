using Microsoft.AspNetCore.Mvc;
using SGA.Application.Dtos.Viaje;
using SGA.Application.Interfaces;

namespace SGA.Api.Desktop.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ViajeController : ControllerBase
    {
        private readonly IViajeService _viajeService;

        public ViajeController(IViajeService viajeService)
        {
            _viajeService = viajeService;
        }


        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var viajes = await _viajeService.GetAllAsync();

            return Ok(viajes);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            if (id <= 0)
                return BadRequest("El ID debe ser mayor que cero.");

            var viaje = await _viajeService.GetByIdAsync(id);

            if (viaje == null)
                return NotFound("No se encontró el viaje.");

            return Ok(viaje);
        }


        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ViajeDto dto)
        {
            if (dto == null)
                return BadRequest("Los datos del viaje no pueden ser nulos.");

            await _viajeService.AddAsync(dto);

            return Ok("Viaje registrado correctamente.");
        }


        [HttpPut]
        public async Task<IActionResult> Put([FromBody] ViajeDto dto)
        {
            if (dto == null)
                return BadRequest("Los datos a actualizar no pueden ser nulos.");

            await _viajeService.UpdateAsync(dto);

            return Ok("Viaje actualizado correctamente.");
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (id <= 0)
                return BadRequest("El ID del viaje debe ser mayor que cero.");

            try
            {
                await _viajeService.DeleteAsync(id);

                return Ok("Viaje eliminado correctamente.");
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}