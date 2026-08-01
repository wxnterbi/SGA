using Microsoft.AspNetCore.Mvc;
using SGA.Application.Dtos.Parada;
using SGA.Application.Interfaces;

namespace SGA.Web.Controllers
{
    public class ParadaController : Controller
    {
        private readonly IParadaService _paradaService;

        public ParadaController(IParadaService paradaService)
        {
            _paradaService = paradaService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var paradas = await _paradaService.GetAllAsync();
            return View(paradas);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateParadaDto dto)
        {
            if (!ModelState.IsValid)
                return View(dto);

            try
            {
                await _paradaService.AddAsync(dto);
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
            var parada = await _paradaService.GetByIdAsync(id);

            if (parada == null)
                return NotFound();

            return View(parada);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(UpdateParadaDto dto)
        {
            if (!ModelState.IsValid)
                return View(dto);

            try
            {
                await _paradaService.UpdateAsync(dto);
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
            var parada = await _paradaService.GetByIdAsync(id);

            if (parada == null)
                return NotFound();

            return View(parada);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var parada = await _paradaService.GetByIdAsync(id);

            if (parada == null)
                return NotFound();

            return View(parada);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _paradaService.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
