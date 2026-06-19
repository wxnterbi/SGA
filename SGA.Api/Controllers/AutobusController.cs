using Microsoft.AspNetCore.Mvc;
using SGA.Domain.Entities.Configuration;
using SGA.Persistence.Interfaces;

namespace SGA.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutobusController : ControllerBase
    {
        private readonly IAutobusRepository _autobusRepository;

        public AutobusController(IAutobusRepository autobusRepository)
        {
            _autobusRepository = autobusRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_autobusRepository.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var autobus = _autobusRepository.GetById(id);

            if (autobus == null)
            {
                return NotFound("Autobús no encontrado.");
            }

            return Ok(autobus);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Autobus autobus)
        {
            var nuevoAutobus = _autobusRepository.Add(autobus);

            return Ok(nuevoAutobus);
        }

        [HttpPut]
        public IActionResult Put([FromBody] Autobus autobus)
        {
            var autobusActualizado = _autobusRepository.Update(autobus);

            return Ok(autobusActualizado);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var eliminado = _autobusRepository.Delete(id);

            if (!eliminado)
            {
                return NotFound("Autobús no encontrado.");
            }

            return Ok("Autobús eliminado correctamente.");
        }
    }
}
