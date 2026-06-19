using Microsoft.AspNetCore.Mvc;
using SGA.Domain.Entities.Configuration;
using SGA.Persistence.Interfaces;

namespace SGA.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RutaController : ControllerBase
    {
        private readonly IRutaRepository _rutaRepository;

        public RutaController(IRutaRepository rutaRepository)
        {
            _rutaRepository = rutaRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_rutaRepository.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var ruta = _rutaRepository.GetById(id);

            if (ruta == null)
                return NotFound();

            return Ok(ruta);
        }

        [HttpPost]
        public IActionResult Post(Ruta ruta)
        {
            return Ok(_rutaRepository.Add(ruta));
        }

        [HttpPut]
        public IActionResult Put(Ruta ruta)
        {
            return Ok(_rutaRepository.Update(ruta));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_rutaRepository.Delete(id));
        }
    }
}
