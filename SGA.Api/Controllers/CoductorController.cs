using Microsoft.AspNetCore.Mvc;
using SGA.Domain.Entities.Configuration;
using SGA.Persistence.Interfaces;

namespace SGA.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConductorController : ControllerBase
    {
        private readonly IConductorRepository _conductorRepository;

        public ConductorController(IConductorRepository conductorRepository)
        {
            _conductorRepository = conductorRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_conductorRepository.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var conductor = _conductorRepository.GetById(id);

            if (conductor == null)
                return NotFound();

            return Ok(conductor);
        }

        [HttpPost]
        public IActionResult Post(Conductor conductor)
        {
            return Ok(_conductorRepository.Add(conductor));
        }

        [HttpPut]
        public IActionResult Put(Conductor conductor)
        {
            return Ok(_conductorRepository.Update(conductor));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_conductorRepository.Delete(id));
        }
    }
}
