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

        // GET
        public async Task<IActionResult> Recargar(int id)
        {
            var tarjeta = await _tarjetaApiService.GetByIdAsync(id);

            if (tarjeta == null)
                return NotFound();

            var model = new RecargarSaldoViewModel
            {
                TarjetaId = tarjeta.Id,
                UsuarioId = tarjeta.UsuarioId,
                SaldoActual = tarjeta.Saldo
            };

            return View(model);
        }

        // POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Recargar(RecargarSaldoViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var resultado = await _tarjetaApiService.RecargarSaldoAsync(model);

            if (!resultado)
            {
                ViewBag.Error = "No fue posible realizar la recarga.";
                return View(model);
            }

            TempData["Success"] = "La recarga se realizó correctamente.";

            return RedirectToAction(nameof(Details), new { id = model.TarjetaId });
        }
    }
}
