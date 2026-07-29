using Microsoft.AspNetCore.Mvc;
using SGA.Application.Dtos.Autobus;
using SGA.Application.Interfaces;

namespace SGA.Web.Controllers
{
    public class AutobusController : Controller
    {
        private readonly IAutobusService _autobusService;

        public AutobusController(IAutobusService autobusService)
        {
            _autobusService = autobusService;
        }

        public async Task<IActionResult> Index()
        {
            var autobuses = await _autobusService.GetAllAsync();
            return View(autobuses);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(AutobusDto dto)
        {
            if (!ModelState.IsValid)
                return View(dto);

            dto.Marca = "";
            dto.Modelo = "";

            try
            {
                await _autobusService.AddAsync(dto);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View(dto);
            }
        }

        public async Task<IActionResult> Details(int id)
        {
            var autobus = await _autobusService.GetByIdAsync(id);

            if (autobus == null)
                return NotFound();

            return View(autobus);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var autobus = await _autobusService.GetByIdAsync(id);

            if (autobus == null)
                return NotFound();

            return View(autobus);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(AutobusDto dto)
        {
            if (!ModelState.IsValid)
                return View(dto);

            dto.Marca = "";
            dto.Modelo = "";

            try
            {
                await _autobusService.UpdateAsync(dto);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View(dto);
            }
        }

        public async Task<IActionResult> Delete(int id)
        {
            var autobus = await _autobusService.GetByIdAsync(id);

            if (autobus == null)
                return NotFound();

            return View(autobus);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _autobusService.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
