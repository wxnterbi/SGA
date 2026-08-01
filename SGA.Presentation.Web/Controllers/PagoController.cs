using Microsoft.AspNetCore.Mvc;
using SGA.Web.Interfaces.Pago;
using SGA.Web.Models.Pago;

namespace SGA.Web.Controllers
{
    public class PagoController : Controller
    {
        private readonly IPagoApiService _pagoApiService;

        public PagoController(IPagoApiService pagoApiService)
        {
            _pagoApiService = pagoApiService;
        }

        // GET: Pago
        public async Task<IActionResult> Index()
        {
            var pagos = await _pagoApiService.GetAllAsync();
            return View(pagos);
        }

        // GET: Pago/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var pago = await _pagoApiService.GetByIdAsync(id);

            if (pago == null)
                return NotFound();

            return View(pago);
        }

        // GET: Pago/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Pago/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(PagoViewModel pago)
        {
            if (!ModelState.IsValid)
                return View(pago);

            var resultado = await _pagoApiService.CreateAsync(pago);

            if (!resultado)
            {
                ViewBag.Error = "No se pudo registrar el pago.";
                return View(pago);
            }

            return RedirectToAction(nameof(Index));
        }

        // GET: Pago/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var pago = await _pagoApiService.GetByIdAsync(id);

            if (pago == null)
                return NotFound();

            return View(pago);
        }

        // POST: Pago/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(PagoViewModel pago)
        {
            if (!ModelState.IsValid)
                return View(pago);

            var resultado = await _pagoApiService.UpdateAsync(pago);

            if (!resultado)
            {
                ViewBag.Error = "No se pudo actualizar el pago.";
                return View(pago);
            }

            return RedirectToAction(nameof(Index));
        }

        // GET: Pago/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var pago = await _pagoApiService.GetByIdAsync(id);

            if (pago == null)
                return NotFound();

            return View(pago);
        }

        // POST: Pago/Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var resultado = await _pagoApiService.DeleteAsync(id);

            if (!resultado)
            {
                ViewBag.Error = "No se pudo eliminar el pago.";
                return View();
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
