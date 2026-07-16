using Microsoft.AspNetCore.Mvc;
using SGA.Application.Dtos.TicketMensual;
using SGA.Application.Interfaces;

namespace SGA.Api.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TicketMensualController : ControllerBase
    {
        private readonly ITicketMensualService _ticketMensualService;

        public TicketMensualController(ITicketMensualService ticketMensualService)
        {
            _ticketMensualService = ticketMensualService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var tickets = await _ticketMensualService.GetAllAsync();
            return Ok(tickets);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            if (id <= 0)
                return BadRequest("El ID debe ser mayor que cero.");

            var ticket = await _ticketMensualService.GetByIdAsync(id);

            if (ticket == null)
                return NotFound("No se encontró el ticket mensual.");

            return Ok(ticket);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] TicketMensualDto dto)
        {
            if (dto == null)
                return BadRequest("Debe enviar los datos del ticket mensual.");

            await _ticketMensualService.AddAsync(dto);

            return Ok("Ticket mensual registrado correctamente.");
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] TicketMensualDto dto)
        {
            if (dto == null)
                return BadRequest("Debe enviar los datos del ticket mensual.");

            if (dto.Id <= 0)
                return BadRequest("El ID del ticket mensual debe ser mayor que cero.");

            await _ticketMensualService.UpdateAsync(dto);

            return Ok("Ticket mensual actualizado correctamente.");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (id <= 0)
                return BadRequest("El ID debe ser mayor que cero.");

            await _ticketMensualService.DeleteAsync(id);

            return Ok("Ticket mensual eliminado correctamente.");
        }
    }
}
