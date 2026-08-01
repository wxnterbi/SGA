using Microsoft.AspNetCore.Mvc;
using SGA.Web.Interfaces.TarjetaRecargable;
using SGA.Web.Models.TarjetaRecargable;

namespace SGA.Web.Controllers
{
    public class TarjetaRecargableController : Controller
    {
        private readonly ITarjetaRecargableApiService _tarjetaApiService;

        public TarjetaRecargableController(ITarjetaRecargableApiService tarjetaApiService)
        {
            _tarjetaApiService = tarjetaApiService;
        }

        // GET: TarjetaRecargable
        public async Task<IActionResult> Index()
        {
            var tarjetas = await _tarjetaApiService.GetAllAsync();
            return View(tarjetas);
        }

        // GET: TarjetaRecargable/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var tarjeta = await _tarjetaApiService.GetByIdAsync(id);

            if (tarjeta == null)
                return NotFound();

            return View(tarjeta);
        }

        // GET: TarjetaRecargable/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TarjetaRecargable/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TarjetaRecargableViewModel tarjeta)
        {
            if (!ModelState.IsValid)
                return View(tarjeta);

            var resultado = await _tarjetaApiService.CreateAsync(tarjeta);

            if (!resultado)
            {
                ViewBag.Error = "No se pudo registrar la tarjeta.";
                return View(tarjeta);
            }

            return RedirectToAction(nameof(Index));
        }

        // GET: TarjetaRecargable/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var tarjeta = await _tarjetaApiService.GetByIdAsync(id);

            if (tarjeta == null)
                return NotFound();

            return View(tarjeta);
        }

        // POST: TarjetaRecargable/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(TarjetaRecargableViewModel tarjeta)
        {
            if (!ModelState.IsValid)
                return View(tarjeta);

            var resultado = await _tarjetaApiService.UpdateAsync(tarjeta);

            if (!resultado)
            {
                ViewBag.Error = "No se pudo actualizar la tarjeta.";
                return View(tarjeta);
            }

            return RedirectToAction(nameof(Index));
        }

        // GET: TarjetaRecargable/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var tarjeta = await _tarjetaApiService.GetByIdAsync(id);

            if (tarjeta == null)
                return NotFound();

            return View(tarjeta);
        }

        // POST: TarjetaRecargable/Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var resultado = await _tarjetaApiService.DeleteAsync(id);

            if (!resultado)
            {
                ViewBag.Error = "No se pudo eliminar la tarjeta.";
                return View();
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
