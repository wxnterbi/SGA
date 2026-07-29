using Microsoft.AspNetCore.Mvc;
using SGA.Application.Dtos.Ruta;
using SGA.Application.Interfaces;

namespace SGA.Web.Controllers
{
    public class RutaController : Controller
    {
        private readonly IRutaService _rutaService;

        public RutaController(IRutaService rutaService)
        {
            _rutaService = rutaService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var rutas = await _rutaService.GetAllAsync();
            return View(rutas);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(RutaDto dto)
        {
            if (!ModelState.IsValid)
                return View(dto);

            try
            {
                await _rutaService.AddAsync(dto);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View(dto);
            }
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var ruta = await _rutaService.GetByIdAsync(id);

            if (ruta == null)
                return NotFound();

            return View(ruta);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(RutaDto dto)
        {
            if (!ModelState.IsValid)
                return View(dto);

            try
            {
                await _rutaService.UpdateAsync(dto);
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
            var ruta = await _rutaService.GetByIdAsync(id);

            if (ruta == null)
                return NotFound();

            return View(ruta);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var ruta = await _rutaService.GetByIdAsync(id);

            if (ruta == null)
                return NotFound();

            return View(ruta);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _rutaService.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
