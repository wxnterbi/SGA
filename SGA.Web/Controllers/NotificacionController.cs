using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SGA.Application.Dtos.Notificacion;
using SGA.Application.Interfaces;
using SGA.Persistence.Context;

namespace SGA.Web.Controllers
{
    public class NotificacionController : Controller
    {
        private readonly INotificacionService _notificacionService;
        private readonly SGABD _context;

        public NotificacionController(
            INotificacionService notificacionService,
            SGABD context)
        {
            _notificacionService = notificacionService;
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var notificaciones = await _notificacionService.GetAllAsync();
            return View(notificaciones);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(NotificacionDto dto)
        {
            if (!ModelState.IsValid)
                return View(dto);

            // Validar que el usuario exista
            bool existeUsuario = await _context.Usuarios
                .AnyAsync(x => x.Id == dto.UsuarioId);

            if (!existeUsuario)
            {
                ModelState.AddModelError("", "El usuario no existe.");
                return View(dto);
            }

            try
            {
                await _notificacionService.AddAsync(dto);
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
            var notificacion = await _notificacionService.GetByIdAsync(id);

            if (notificacion == null)
                return NotFound();

            return View(notificacion);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var notificacion = await _notificacionService.GetByIdAsync(id);

            if (notificacion == null)
                return NotFound();

            return View(notificacion);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(NotificacionDto dto)
        {
            if (!ModelState.IsValid)
                return View(dto);

            bool existeUsuario = await _context.Usuarios
                .AnyAsync(x => x.Id == dto.UsuarioId);

            if (!existeUsuario)
            {
                ModelState.AddModelError("", "El usuario no existe.");
                return View(dto);
            }

            try
            {
                await _notificacionService.UpdateAsync(dto);
                return RedirectToAction(nameof(Index));
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
            var notificacion = await _notificacionService.GetByIdAsync(id);

            if (notificacion == null)
                return NotFound();

            return View(notificacion);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            try
            {
                await _notificacionService.DeleteAsync(id);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);

                var notificacion = await _notificacionService.GetByIdAsync(id);
                return View(notificacion);
            }
        }
    }
}
