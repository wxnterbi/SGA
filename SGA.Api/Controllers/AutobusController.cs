using Microsoft.AspNetCore.Mvc;
using SGA.Application.Dtos.Autobus;
using SGA.Application.Interfaces;
using System.Threading.Tasks;

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
        public async Task<IActionResult> GetAll()
        {
            var result = await _autobusService.GetAllAsync();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _autobusService.GetByIdAsync(id);
            if (result == null) return NotFound($"No se encontró el autobús con ID {id}");
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] AutobusDto dto)
        {
            await _autobusService.AddAsync(dto);
            return Ok(new { message = "Autobús registrado correctamente." });
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] AutobusDto dto)
        {
            await _autobusService.UpdateAsync(dto);
            return Ok(new { message = "Autobús actualizado correctamente o verificado." });
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _autobusService.DeleteAsync(id);
            return Ok(new { message = "Proceso de eliminación ejecutado." });
        }
    }
}