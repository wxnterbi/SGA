using Microsoft.AspNetCore.Mvc;
using SGA.Application.Dtos.Incidencia;
using SGA.Application.Interfaces;
using System.Threading.Tasks;

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
        public async Task<IActionResult> GetAll()
        {
            var result = await _incidenciaService.GetAllAsync();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _incidenciaService.GetByIdAsync(id);
            if (result == null) return NotFound($"No se encontró la incidencia con ID {id}");
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] IncidenciaDto dto)
        {
            await _incidenciaService.AddAsync(dto);
            return Ok(new { message = "Incidencia registrada correctamente." });
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] IncidenciaDto dto)
        {
            await _incidenciaService.UpdateAsync(dto);
            return Ok(new { message = "Incidencia actualizada correctamente." });
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _incidenciaService.DeleteAsync(id);
            return Ok(new { message = "Proceso de eliminación ejecutado." });
        }
    }
}