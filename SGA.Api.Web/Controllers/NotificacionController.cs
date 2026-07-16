using Microsoft.AspNetCore.Mvc;
using SGA.Application.Dtos.Notificacion;
using SGA.Application.Interfaces;

namespace SGA.Api.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NotificacionController : ControllerBase
    {
        private readonly INotificacionService _notificacionService;

        public NotificacionController(INotificacionService notificacionService)
        {
            _notificacionService = notificacionService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var notificaciones = await _notificacionService.GetAllAsync();
            return Ok(notificaciones);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            if (id <= 0)
                return BadRequest("El ID debe ser mayor que cero.");

            var notificacion = await _notificacionService.GetByIdAsync(id);

            if (notificacion == null)
                return NotFound("No se encontró la notificación.");

            return Ok(notificacion);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] NotificacionDto dto)
        {
            if (dto == null)
                return BadRequest("Debe enviar los datos de la notificación.");

            await _notificacionService.AddAsync(dto);

            return Ok("Notificación registrada correctamente.");
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] NotificacionDto dto)
        {
            if (dto == null)
                return BadRequest("Debe enviar los datos de la notificación.");

            if (dto.Id <= 0)
                return BadRequest("El ID de la notificación debe ser mayor que cero.");

            await _notificacionService.UpdateAsync(dto);

            return Ok("Notificación actualizada correctamente.");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (id <= 0)
                return BadRequest("El ID debe ser mayor que cero.");

            await _notificacionService.DeleteAsync(id);

            return Ok("Notificación eliminada correctamente.");
        }
    }
}
