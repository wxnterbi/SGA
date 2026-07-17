using Microsoft.AspNetCore.Mvc;
using SGA.Application.Dtos.TarjetaRecargable;
using SGA.Application.Interfaces;

namespace SGA.Api.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TarjetaRecargableController : ControllerBase
    {
        private readonly ITarjetaRecargableService _tarjetaRecargableService;

        public TarjetaRecargableController(ITarjetaRecargableService tarjetaRecargableService)
        {
            _tarjetaRecargableService = tarjetaRecargableService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var tarjetas = await _tarjetaRecargableService.GetAllAsync();
            return Ok(tarjetas);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            if (id <= 0)
                return BadRequest("El ID debe ser mayor que cero.");

            var tarjeta = await _tarjetaRecargableService.GetByIdAsync(id);

            if (tarjeta == null)
                return NotFound("No se encontró la tarjeta.");

            return Ok(tarjeta);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] TarjetaRecargableDto dto)
        {
            await _tarjetaRecargableService.AddAsync(dto);

            return Ok("Tarjeta registrada correctamente.");
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] TarjetaRecargableDto dto)
        {
            try
            {
                await _tarjetaRecargableService.UpdateAsync(dto);
                return Ok("Tarjeta actualizada correctamente.");
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (id <= 0)
                return BadRequest("El ID debe ser mayor que cero.");
            try
            {
                await _tarjetaRecargableService.DeleteAsync(id);
                return Ok("Tarjeta eliminada correctamente.");

            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}
