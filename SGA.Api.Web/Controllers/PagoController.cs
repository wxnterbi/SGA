using Microsoft.AspNetCore.Mvc;
using SGA.Application.Dtos.Pago;
using SGA.Application.Interfaces;

namespace SGA.Api.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PagoController : ControllerBase
    {
        private readonly IPagoService _pagoService;

        public PagoController(IPagoService pagoService)
        {
            _pagoService = pagoService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var pagos = await _pagoService.GetAllAsync();
                return Ok(pagos);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            if (id <= 0)
                return BadRequest("El ID debe ser mayor que cero.");

            var pago = await _pagoService.GetByIdAsync(id);

            if (pago == null)
                return NotFound("No se encontró el pago.");

            return Ok(pago);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] PagoDto dto)
        {
            await _pagoService.AddAsync(dto);

            return Ok("Pago registrado correctamente.");
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] PagoDto dto)
        {
            await _pagoService.UpdateAsync(dto);

            return Ok("Pago actualizado correctamente.");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (id <= 0)
                return BadRequest("El ID del pago debe ser mayor que cero.");
            try
            {
                await _pagoService.DeleteAsync(id);
                return Ok("Pago eliminado correctamente.");
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);

            }
        }
        [HttpPost("ComprarTicket")]
        public async Task<IActionResult> ComprarTicket([FromBody] ComprarTicketDto dto)
        {
            try
            {
                await _pagoService.ComprarTicketAsync(dto);
                return Ok();
            }
            catch (Exception ex)
            {
                var e = ex;

                while (e.InnerException != null)
                    e = e.InnerException;

                return BadRequest(e.Message);
            }
        }
    }
}

