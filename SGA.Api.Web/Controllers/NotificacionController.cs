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
            var notificacion = await _notificacionService.GetByIdAsync(id);

            if (notificacion == null)
                return NotFound();

            return Ok(notificacion);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] NotificacionDto dto)
        {
            await _notificacionService.AddAsync(dto);
            return Ok("Notificación registrada correctamente.");
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] NotificacionDto dto)
        {
            await _notificacionService.UpdateAsync(dto);
            return Ok("Notificación actualizada correctamente.");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _notificacionService.DeleteAsync(id);
            return Ok("Notificación eliminada correctamente.");
        }
    }
}
