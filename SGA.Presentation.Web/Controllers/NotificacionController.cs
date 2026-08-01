using Microsoft.AspNetCore.Mvc;
using SGA.Web.Interfaces.Notificacion;
using SGA.Web.Models.Notificacion;

namespace SGA.Web.Controllers
{
    public class NotificacionController : Controller
    {
        private readonly INotificacionApiService _notificacionApiService;

        public NotificacionController(INotificacionApiService notificacionApiService)
        {
            _notificacionApiService = notificacionApiService;
        }

        // GET: Notificacion
        public async Task<IActionResult> Index()
        {
            var notificaciones = await _notificacionApiService.GetAllAsync();
            return View(notificaciones);
        }

        // GET: Notificacion/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var notificacion = await _notificacionApiService.GetByIdAsync(id);

            if (notificacion == null)
                return NotFound();

            return View(notificacion);
        }

        // GET: Notificacion/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Notificacion/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(NotificacionViewModel notificacion)
        {
            if (!ModelState.IsValid)
                return View(notificacion);

            var resultado = await _notificacionApiService.CreateAsync(notificacion);

            if (!resultado)
            {
                ViewBag.Error = "No se pudo registrar la notificación.";
                return View(notificacion);
            }

            return RedirectToAction(nameof(Index));
        }

        // GET: Notificacion/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var notificacion = await _notificacionApiService.GetByIdAsync(id);

            if (notificacion == null)
                return NotFound();

            return View(notificacion);
        }

        // POST: Notificacion/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(NotificacionViewModel notificacion)
        {
            if (!ModelState.IsValid)
                return View(notificacion);

            var resultado = await _notificacionApiService.UpdateAsync(notificacion);

            if (!resultado)
            {
                ViewBag.Error = "No se pudo actualizar la notificación.";
                return View(notificacion);
            }

            return RedirectToAction(nameof(Index));
        }

        // GET: Notificacion/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var notificacion = await _notificacionApiService.GetByIdAsync(id);

            if (notificacion == null)
                return NotFound();

            return View(notificacion);
        }

        // POST: Notificacion/Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var resultado = await _notificacionApiService.DeleteAsync(id);

            if (!resultado)
            {
                ViewBag.Error = "No se pudo eliminar la notificación.";
                return View();
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
