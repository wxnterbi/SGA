using Microsoft.AspNetCore.Mvc;
using SGA.Application.Dtos.TarjetaRecargable;
using SGA.Application.Interfaces;

namespace SGA.Web.Controllers
{
    public class TarjetaRecargableController : Controller
    {
        private readonly ITarjetaRecargableService _tarjetaService;
        private readonly IUsuarioService _usuarioService;

        public TarjetaRecargableController(
            ITarjetaRecargableService tarjetaService,
            IUsuarioService usuarioService)
        {
            _tarjetaService = tarjetaService;
            _usuarioService = usuarioService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var tarjetas = await _tarjetaService.GetAllAsync();
            return View(tarjetas);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(TarjetaRecargableDto dto)
        {
            if (!ModelState.IsValid)
                return View(dto);

            // Validar que el usuario exista
            var usuario = await _usuarioService.GetByIdAsync(dto.UsuarioId);

            if (usuario == null)
            {
                ModelState.AddModelError("UsuarioId", "El usuario no existe.");
                return View(dto);
            }

            try
            {
                await _tarjetaService.AddAsync(dto);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View(dto);
            }
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var tarjeta = await _tarjetaService.GetByIdAsync(id);

            if (tarjeta == null)
                return NotFound();

            return View(tarjeta);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var tarjeta = await _tarjetaService.GetByIdAsync(id);

            if (tarjeta == null)
                return NotFound();

            return View(tarjeta);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(TarjetaRecargableDto dto)
        {
            if (!ModelState.IsValid)
                return View(dto);

            // Validar que el usuario exista
            var usuario = await _usuarioService.GetByIdAsync(dto.UsuarioId);

            if (usuario == null)
            {
                ModelState.AddModelError("UsuarioId", "El usuario no existe.");
                return View(dto);
            }

            try
            {
                await _tarjetaService.UpdateAsync(dto);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View(dto);
            }
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var tarjeta = await _tarjetaService.GetByIdAsync(id);

            if (tarjeta == null)
                return NotFound();

            return View(tarjeta);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            try
            {
                await _tarjetaService.DeleteAsync(id);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);

                var tarjeta = await _tarjetaService.GetByIdAsync(id);
                return View(tarjeta);
            }
        }
    }
}
