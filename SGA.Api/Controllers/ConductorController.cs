using Microsoft.AspNetCore.Mvc;
using SGA.Application.Dtos.Conductor;
using SGA.Application.Interfaces;
using System.Threading.Tasks;

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
        public async Task<IActionResult> GetAll()
        {
            var result = await _conductorService.GetAllAsync();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _conductorService.GetByIdAsync(id);
            if (result == null) return NotFound($"No se encontró el conductor con ID {id}");
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] ConductorDto dto)
        {
            await _conductorService.AddAsync(dto);
            return Ok(new { message = "Conductor registrado correctamente." });
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] ConductorDto dto)
        {
            await _conductorService.UpdateAsync(dto);
            return Ok(new { message = "Conductor actualizado correctamente." });
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _conductorService.DeleteAsync(id);
            return Ok(new { message = "Proceso de eliminación ejecutado." });
        }
    }
}
