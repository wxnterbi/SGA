using Microsoft.AspNetCore.Mvc;
using SGA.Application.Dtos.Auditoria;
using SGA.Application.Interfaces;

namespace SGA.Web.Controllers
{
    public class AuditoriaController : Controller
    {
        private readonly IAuditoriaService _auditoriaService;

        public AuditoriaController(IAuditoriaService auditoriaService)
        {
            _auditoriaService = auditoriaService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var auditorias = await _auditoriaService.GetAllAsync();
            return View(auditorias);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(AuditoriaDto dto)
        {
            if (!ModelState.IsValid)
                return View(dto);

            try
            {
                await _auditoriaService.AddAsync(dto);
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
            var auditoria = await _auditoriaService.GetByIdAsync(id);

            if (auditoria == null)
                return NotFound();

            return View(auditoria);
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var auditoria = await _auditoriaService.GetByIdAsync(id);

            if (auditoria == null)
                return NotFound();

            return View(auditoria);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var auditoria = await _auditoriaService.GetByIdAsync(id);

            if (auditoria == null)
                return NotFound();

            return View(auditoria);
        }
    }
}