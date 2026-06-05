using Microsoft.AspNetCore.Mvc;
using SGA.Persistence.Context;

namespace SGA.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly SGABD _context;

        public UsuarioController(SGABD context)
        {
            _context = context;
        }

        [HttpGet]
        public int Get()
        {
            return _context.Usuarios.Count();
        }
    }
}