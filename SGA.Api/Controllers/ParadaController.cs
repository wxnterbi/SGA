using Microsoft.AspNetCore.Mvc;
using SGA.Application.Dtos.Parada;
using SGA.Application.Interfaces;

namespace SGA.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ParadaController : ControllerBase
    {
        private readonly IParadaService _paradaService;


        public ParadaController(IParadaService paradaService)
        {
            _paradaService = paradaService;
        }


        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var paradas = await _paradaService.GetAllAsync();

            return Ok(paradas);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            if (id <= 0)
                return BadRequest("El ID debe ser mayor que cero.");


            var parada = await _paradaService.GetByIdAsync(id);


            if (parada == null)
                return NotFound("No se encontró la parada.");


            return Ok(parada);
        }


        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateParadaDto dto)
        {
            await _paradaService.AddAsync(dto);

            return Ok("Parada registrada correctamente.");
        }


        [HttpPut]
        public async Task<IActionResult> Put([FromBody] UpdateParadaDto dto)
        {
            await _paradaService.UpdateAsync(dto);

            return Ok("Parada actualizada correctamente.");
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (id <= 0)
                return BadRequest("El ID de la parada debe ser mayor que cero.");


            try
            {
                await _paradaService.DeleteAsync(id);

                return Ok("Parada eliminada correctamente.");
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}