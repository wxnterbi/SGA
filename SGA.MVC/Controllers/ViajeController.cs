using Microsoft.AspNetCore.Mvc;
using SGA.Application.Dtos.Viaje;
using SGA.Application.Interfaces;

namespace SGA.Web.Controllers
{
    public class ViajeController : Controller
    {
        private readonly IViajeService _viajeService;

        public ViajeController(IViajeService viajeService)
        {
            _viajeService = viajeService;
        }

        public async Task<IActionResult> Index()
        {
            var viajes = await _viajeService.GetAllAsync();
            return View(viajes);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(ViajeDto dto)
        {
            if (!ModelState.IsValid)
                return View(dto);

            try
            {
                await _viajeService.AddAsync(dto);
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
            var viaje = await _viajeService.GetByIdAsync(id);

            if (viaje == null)
                return NotFound();

            return View(viaje);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(ViajeDto dto)
        {
            if (!ModelState.IsValid)
                return View(dto);

            try
            {
                await _viajeService.UpdateAsync(dto);
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
            var viaje = await _viajeService.GetByIdAsync(id);

            if (viaje == null)
                return NotFound();

            return View(viaje);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var viaje = await _viajeService.GetByIdAsync(id);

            if (viaje == null)
                return NotFound();

            return View(viaje);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _viajeService.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
