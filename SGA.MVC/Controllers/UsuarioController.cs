using Microsoft.AspNetCore.Mvc;
using SGA.Application.Dtos.Usuario;
using SGA.Application.Interfaces;

namespace SGA.Web.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var usuarios = await _usuarioService.GetAllAsync();
            return View(usuarios);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateUsuarioDto dto)
        {
            if (!ModelState.IsValid)
                return View(dto);

            try
            {
                await _usuarioService.AddAsync(dto);
                return RedirectToAction(nameof(Index));
            }
            catch (InvalidOperationException ex)
            {
                ModelState.AddModelError("IdentificadorInstitucional", ex.Message);
                return View(dto);
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
            var usuario = await _usuarioService.GetByIdAsync(id);

            if (usuario == null)
                return NotFound();

            return View(usuario);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var usuario = await _usuarioService.GetByIdAsync(id);

            if (usuario == null)
                return NotFound();

            return View(usuario);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(UpdateUsuarioDto dto)
        {
            if (!ModelState.IsValid)
                return View(dto);

            try
            {
                await _usuarioService.UpdateAsync(dto.Id, dto);
                return RedirectToAction(nameof(Index));
            }
            catch (InvalidOperationException ex)
            {
                ModelState.AddModelError("IdentificadorInstitucional", ex.Message);
                return View(dto);
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
            var usuario = await _usuarioService.GetByIdAsync(id);

            if (usuario == null)
                return NotFound();

            return View(usuario);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            try
            {
                await _usuarioService.DeleteAsync(id);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);

                var usuario = await _usuarioService.GetByIdAsync(id);
                return View(usuario);
            }
        }
    }
}