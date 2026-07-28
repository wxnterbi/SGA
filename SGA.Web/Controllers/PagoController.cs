using Microsoft.AspNetCore.Mvc;
using SGA.Application.Dtos.Pago;
using SGA.Application.Interfaces;

namespace SGA.Web.Controllers
{
    public class PagoController : Controller
    {
        private readonly IPagoService _pagoService;

        public PagoController(IPagoService pagoService)
        {
            _pagoService = pagoService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var pagos = await _pagoService.GetAllAsync();
            return View(pagos);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(PagoDto dto)
        {
            if (!ModelState.IsValid)
                return View(dto);

            try
            {
                await _pagoService.AddAsync(dto);
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
            var pago = await _pagoService.GetByIdAsync(id);

            if (pago == null)
                return NotFound();

            return View(pago);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var pago = await _pagoService.GetByIdAsync(id);

            if (pago == null)
                return NotFound();

            return View(pago);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(PagoDto dto)
        {
            if (!ModelState.IsValid)
                return View(dto);

            try
            {
                await _pagoService.UpdateAsync(dto);
                return RedirectToAction("Index"); 
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
            var pago = await _pagoService.GetByIdAsync(id);

            if (pago == null)
                return NotFound();

            return View(pago);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            try
            {
                await _pagoService.DeleteAsync(id);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);

                var pago = await _pagoService.GetByIdAsync(id);
                return View(pago);
            }
        }
    }
}
