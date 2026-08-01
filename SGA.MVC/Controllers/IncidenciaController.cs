using Microsoft.AspNetCore.Mvc;
using SGA.Application.Dtos.Incidencia;
using SGA.Application.Interfaces;

namespace SGA.Web.Controllers
{
    public class IncidenciaController : Controller
    {
        private readonly IIncidenciaService _incidenciaService;

        public IncidenciaController(IIncidenciaService incidenciaService)
        {
            _incidenciaService = incidenciaService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var incidencias = await _incidenciaService.GetAllAsync();
            return View(incidencias);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(IncidenciaDto dto)
        {
            if (!ModelState.IsValid)
                return View(dto);

            try
            {
                await _incidenciaService.AddAsync(dto);
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
            var incidencia = await _incidenciaService.GetByIdAsync(id);

            if (incidencia == null)
                return NotFound();

            return View(incidencia);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(IncidenciaDto dto)
        {
            if (!ModelState.IsValid)
                return View(dto);

            try
            {
                await _incidenciaService.UpdateAsync(dto);
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
            var incidencia = await _incidenciaService.GetByIdAsync(id);

            if (incidencia == null)
                return NotFound();

            return View(incidencia);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var incidencia = await _incidenciaService.GetByIdAsync(id);

            if (incidencia == null)
                return NotFound();

            return View(incidencia);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _incidenciaService.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
