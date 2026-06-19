using Microsoft.AspNetCore.Mvc;
using SGA.Domain.Entities.Configuration;
using SGA.Persistence.Interfaces;

namespace SGA.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParadaController : ControllerBase
    {
        private readonly IParadaRepository _paradaRepository;

        public ParadaController(IParadaRepository paradaRepository)
        {
            _paradaRepository = paradaRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_paradaRepository.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_paradaRepository.GetById(id));
        }

        [HttpPost]
        public IActionResult Post(Parada parada)
        {
            return Ok(_paradaRepository.Add(parada));
        }

        [HttpPut]
        public IActionResult Put(Parada parada)
        {
            return Ok(_paradaRepository.Update(parada));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_paradaRepository.Delete(id));
        }
    }
}
