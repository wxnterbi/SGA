using Microsoft.AspNetCore.Mvc;
using SGA.Web.Interfaces.RegistroAcceso;
using SGA.Web.Models.RegistroAcceso;

namespace SGA.Web.Controllers
{
    public class RegistroAccesoController : Controller
    {
        private readonly IRegistroAccesoApiService _registroApiService;

        public RegistroAccesoController(IRegistroAccesoApiService registroApiService)
        {
            _registroApiService = registroApiService;
        }
        public async Task<IActionResult> MisAccesos()
        {
            int usuarioId = 2; // luego será el usuario autenticado

            var registros = await _registroApiService.GetByUsuarioIdAsync(usuarioId);

            registros = registros
                .OrderByDescending(x => x.FechaHora)
                .ToList();

            return View(registros);
        }

        // GET: RegistroAcceso
        public async Task<IActionResult> Index()
        {
            int usuarioId = 2;

            var registros = await _registroApiService.GetAllAsync();

            registros = registros
                .Where(x => x.UsuarioId == usuarioId)
                .OrderByDescending(x => x.FechaHora)
                .ToList();

            return View(registros);
        }

        // GET: RegistroAcceso/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var registro = await _registroApiService.GetByIdAsync(id);

            if (registro == null)
                return NotFound();

            return View(registro);
        }

        // GET: RegistroAcceso/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: RegistroAcceso/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(RegistroAccesoViewModel registro)
        {
            if (!ModelState.IsValid)
                return View(registro);

            var resultado = await _registroApiService.CreateAsync(registro);

            if (!resultado)
            {
                ViewBag.Error = "No se pudo registrar el acceso.";
                return View(registro);
            }

            return RedirectToAction(nameof(Index));
        }

        // GET: RegistroAcceso/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var registro = await _registroApiService.GetByIdAsync(id);

            if (registro == null)
                return NotFound();

            return View(registro);
        }

        // POST: RegistroAcceso/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(RegistroAccesoViewModel registro)
        {
            if (!ModelState.IsValid)
                return View(registro);

            var resultado = await _registroApiService.UpdateAsync(registro);

            if (!resultado)
            {
                ViewBag.Error = "No se pudo actualizar el registro.";
                return View(registro);
            }

            return RedirectToAction(nameof(Index));
        }

        // GET: RegistroAcceso/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var registro = await _registroApiService.GetByIdAsync(id);

            if (registro == null)
                return NotFound();

            return View(registro);
        }

        // POST: RegistroAcceso/Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var resultado = await _registroApiService.DeleteAsync(id);

            if (!resultado)
            {
                ViewBag.Error = "No se pudo eliminar el registro.";
                return View();
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
