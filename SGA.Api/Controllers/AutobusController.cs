using Microsoft.AspNetCore.Mvc;
using SGA.Application.Dtos.Autobus;
using SGA.Application.Interfaces;

namespace SGA.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AutobusController : ControllerBase
    {
        private readonly IAutobusService _autobusService;

        public AutobusController(IAutobusService autobusService)
        {
            _autobusService = autobusService;
        }


        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var autobuses = await _autobusService.GetAllAsync();

            return Ok(autobuses);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            if (id <= 0)
                return BadRequest("El ID debe ser mayor que cero.");

            var autobus = await _autobusService.GetByIdAsync(id);

            if (autobus == null)
                return NotFound("No se encontró el autobús.");

            return Ok(autobus);
        }


        [HttpPost]
        public async Task<IActionResult> Post([FromBody] AutobusDto dto)
        {
            if (dto == null)
            {
                return BadRequest("El objeto AutobusDto llegó vacío.");
            }


            try
            {
                await _autobusService.AddAsync(dto);

                return Ok("Autobús registrado correctamente.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpPut]
        public async Task<IActionResult> Put([FromBody] AutobusDto dto)
        {
            await _autobusService.UpdateAsync(dto);

            return Ok("Autobús actualizado correctamente.");
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (id <= 0)
                return BadRequest("El ID del autobús debe ser mayor que cero.");

            try
            {
                await _autobusService.DeleteAsync(id);

                return Ok("Autobús eliminado correctamente.");
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}