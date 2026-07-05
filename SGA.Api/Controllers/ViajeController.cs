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
        public async Task<IActionResult> GetAll()
        {
            var viajes = await _viajeService.GetAllAsync();
            return Ok(viajes);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var viaje = await _viajeService.GetByIdAsync(id);
            if (viaje == null) return NotFound($"No se encontró el viaje con ID {id}.");
            return Ok(viaje);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] ViajeDto viajeDto)
        {
            if (viajeDto == null) return BadRequest("Los datos del viaje no pueden ser nulos.");

            await _viajeService.AddAsync(viajeDto);
            return Ok("Viaje creado correctamente.");
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] ViajeDto viajeDto)
        {
            if (viajeDto == null) return BadRequest("Los datos a actualizar no pueden ser nulos.");

            var existe = await _viajeService.GetByIdAsync(viajeDto.Id);
            if (existe == null) return NotFound($"No se encontró el viaje con ID {viajeDto.Id} para actualizar.");

            await _viajeService.UpdateAsync(viajeDto);
            return Ok("Viaje actualizado correctamente.");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var existe = await _viajeService.GetByIdAsync(id);
            if (existe == null) return NotFound($"No se encontró el viaje con ID {id}.");

            await _viajeService.DeleteAsync(id);
            return Ok("Viaje eliminado correctamente.");
        }
    }
}