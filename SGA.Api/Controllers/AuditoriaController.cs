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

        public AuditoriaController(
            IAuditoriaService auditoriaService)
        {
            _auditoriaService = auditoriaService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var auditorias =
                await _auditoriaService.GetAllAsync();

            return Ok(auditorias);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            if (id <= 0)
            {
                return BadRequest(
                    "El ID de auditoría debe ser mayor que cero.");
            }

            var auditoria =
                await _auditoriaService.GetByIdAsync(id);

            if (auditoria == null)
            {
                return NotFound(
                    $"No se encontró el registro de auditoría con ID {id}.");
            }

            return Ok(auditoria);
        }

        [HttpPost]
        public async Task<IActionResult> Create(
            [FromBody] CreateAuditoriaDto dto)
        {
            if (dto == null)
            {
                return BadRequest(
                    "Los datos de auditoría no pueden ser nulos.");
            }

            if (string.IsNullOrWhiteSpace(dto.Actor))
            {
                return BadRequest(
                    "El actor es obligatorio.");
            }

            if (string.IsNullOrWhiteSpace(dto.TipoAccion))
            {
                return BadRequest(
                    "El tipo de acción es obligatorio.");
            }

            if (string.IsNullOrWhiteSpace(dto.Descripcion))
            {
                return BadRequest(
                    "La descripción es obligatoria.");
            }

            if (dto.Actor.Trim().Length > 60)
            {
                return BadRequest(
                    "El actor no puede exceder los 60 caracteres.");
            }

            if (dto.TipoAccion.Trim().Length > 50)
            {
                return BadRequest(
                    "El tipo de acción no puede exceder los 50 caracteres.");
            }

            if (dto.Descripcion.Trim().Length > 500)
            {
                return BadRequest(
                    "La descripción no puede exceder los 500 caracteres.");
            }

            await _auditoriaService.AddAsync(dto);

            return Ok(
                "Registro de auditoría guardado con éxito.");
        }

        [HttpPut]
        public IActionResult Update()
        {
            return StatusCode(
                StatusCodes.Status405MethodNotAllowed,
                "Los registros de auditoría no pueden modificarse.");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return StatusCode(
                StatusCodes.Status405MethodNotAllowed,
                "Los registros de auditoría no pueden eliminarse.");
        }
    }
}