using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SGA.Application.Dtos.RegistroAcceso;
using SGA.Application.Interfaces;

namespace SGA.Web.Controllers
{
    public class RegistroAccesoController : Controller
    {
        private readonly IRegistroAccesoService _registroAccesoService;
        private readonly IUsuarioService _usuarioService;
        private readonly IViajeService _viajeService;

        public RegistroAccesoController(
            IRegistroAccesoService registroAccesoService,
            IUsuarioService usuarioService,
            IViajeService viajeService)
        {
            _registroAccesoService = registroAccesoService;
            _usuarioService = usuarioService;
            _viajeService = viajeService;
        }

        private async Task CargarCombos()
        {
            var usuarios = await _usuarioService.GetAllAsync();

            ViewBag.Usuarios = usuarios.Select(u => new SelectListItem
            {
                Value = u.Id.ToString(),
                Text = u.Nombre
            }).ToList();

            var viajes = await _viajeService.GetAllAsync();

            ViewBag.Viajes = viajes.Select(v => new SelectListItem
            {
                Value = v.Id.ToString(),
                Text = $"Viaje {v.Id} - Ruta {v.RutaId}"
            }).ToList();
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var registros = await _registroAccesoService.GetAllAsync();
            return View(registros);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            await CargarCombos();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(RegistroAccesoDto dto)
        {
            if (!ModelState.IsValid)
            {
                await CargarCombos();
                return View(dto);
            }

            try
            {
                await _registroAccesoService.AddAsync(dto);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                await CargarCombos();
                return View(dto);
            }
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var registro = await _registroAccesoService.GetByIdAsync(id);

            if (registro == null)
                return NotFound();

            return View(registro);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var registro = await _registroAccesoService.GetByIdAsync(id);

            if (registro == null)
                return NotFound();

            await CargarCombos();

            return View(registro);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(RegistroAccesoDto dto)
        {
            if (!ModelState.IsValid)
            {
                await CargarCombos();
                return View(dto);
            }

            try
            {
                await _registroAccesoService.UpdateAsync(dto);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                await CargarCombos();
                return View(dto);
            }
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var registro = await _registroAccesoService.GetByIdAsync(id);

            if (registro == null)
                return NotFound();

            return View(registro);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            try
            {
                await _registroAccesoService.DeleteAsync(id);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);

                var registro = await _registroAccesoService.GetByIdAsync(id);

                return View(registro);
            }
        }
    }
}