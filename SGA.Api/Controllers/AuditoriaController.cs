using Microsoft.AspNetCore.Mvc;
using SGA.Application.Dtos.Auditoria;
using SGA.Application.Interfaces;

namespace SGA.Api.Desktop.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuditoriaController : ControllerBase
    {
        private readonly IAuditoriaService _auditoriaService;

        public AuditoriaController(IAuditoriaService auditoriaService)
        {
            _auditoriaService = auditoriaService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var auditorias = await _auditoriaService.GetAllAsync();
            return Ok(auditorias);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var auditoria = await _auditoriaService.GetByIdAsync(id);
            if (auditoria == null) return NotFound($"No se encontró el registro de auditoría con ID {id}.");
            return Ok(auditoria);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] AuditoriaDto auditoriaDto)
        {
            if (auditoriaDto == null) return BadRequest("Los datos de auditoría no pueden ser nulos.");

            await _auditoriaService.AddAsync(auditoriaDto);
            return Ok("Registro de auditoría guardado con éxito.");
        }
    }
}