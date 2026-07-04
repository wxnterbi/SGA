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
            var pagos = await _pagoService.GetAllAsync();
            return Ok(pagos);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var pago = await _pagoService.GetByIdAsync(id);

            if (pago == null)
                return NotFound();

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
            await _pagoService.DeleteAsync(id);
            return Ok("Pago eliminado correctamente.");
        }
    }
}
