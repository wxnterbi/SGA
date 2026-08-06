using Microsoft.AspNetCore.Mvc;
using SGA.Application.Dtos.Horario;
using SGA.Application.Interfaces;

namespace SGA.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HorarioController : ControllerBase
    {
        private readonly IHorarioService _horarioService;

        public HorarioController(IHorarioService horarioService)
        {
            _horarioService = horarioService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var horarios = await _horarioService.GetAllAsync();

            return Ok(horarios);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            if (id <= 0)
                return BadRequest("El ID debe ser mayor que cero.");

            var horario = await _horarioService.GetByIdAsync(id);

            if (horario == null)
                return NotFound("No se encontró el horario.");

            return Ok(horario);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] HorarioDto dto)
        {
            await _horarioService.AddAsync(dto);

            return Ok("Horario registrado correctamente.");
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] HorarioDto dto)
        {
            await _horarioService.UpdateAsync(dto);

            return Ok("Horario actualizado correctamente.");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (id <= 0)
                return BadRequest("El ID del horario debe ser mayor que cero.");

            await _horarioService.DeleteAsync(id);

            return Ok("Horario eliminado correctamente.");
        }
    }
}