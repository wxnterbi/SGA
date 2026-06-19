using Microsoft.AspNetCore.Mvc;
using SGA.Domain.Entities.Configuration;
using SGA.Persistence.Interfaces;

namespace SGA.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HorarioController : ControllerBase
    {
        private readonly IHorarioRepository _horarioRepository;

        public HorarioController(IHorarioRepository horarioRepository)
        {
            _horarioRepository = horarioRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_horarioRepository.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_horarioRepository.GetById(id));
        }

        [HttpPost]
        public IActionResult Post(Horario horario)
        {
            return Ok(_horarioRepository.Add(horario));
        }

        [HttpPut]
        public IActionResult Put(Horario horario)
        {
            return Ok(_horarioRepository.Update(horario));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_horarioRepository.Delete(id));
        }
    }
}
