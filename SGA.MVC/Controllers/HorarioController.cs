using Microsoft.AspNetCore.Mvc;
using SGA.Application.Dtos.Horario;
using SGA.Application.Interfaces;

namespace SGA.Web.Controllers
{
    public class HorarioController : Controller
    {
        private readonly IHorarioService _horarioService;

        public HorarioController(IHorarioService horarioService)
        {
            _horarioService = horarioService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var horarios = await _horarioService.GetAllAsync();
            return View(horarios);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(HorarioDto dto)
        {
            if (!ModelState.IsValid)
                return View(dto);

            try
            {
                await _horarioService.AddAsync(dto);
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
            var horario = await _horarioService.GetByIdAsync(id);

            if (horario == null)
                return NotFound();

            return View(horario);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(HorarioDto dto)
        {
            if (!ModelState.IsValid)
                return View(dto);

            try
            {
                await _horarioService.UpdateAsync(dto);
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
            var horario = await _horarioService.GetByIdAsync(id);

            if (horario == null)
                return NotFound();

            return View(horario);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var horario = await _horarioService.GetByIdAsync(id);

            if (horario == null)
                return NotFound();

            return View(horario);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _horarioService.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
