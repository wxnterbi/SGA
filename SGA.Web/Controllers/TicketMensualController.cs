using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SGA.Application.Dtos.TicketMensual;
using SGA.Application.Interfaces;
using SGA.Persistence.Context;

namespace SGA.Web.Controllers
{
    public class TicketMensualController : Controller
    {
        private readonly ITicketMensualService _ticketMensualService;
        private readonly SGABD _context;

        public TicketMensualController(
            ITicketMensualService ticketMensualService,
            SGABD context)
        {
            _ticketMensualService = ticketMensualService;
            _context = context;
        }

        private async Task CargarCombos()
        {
            ViewBag.Usuarios = new SelectList(
                await _context.Usuarios.ToListAsync(),
                "Id",
                "Nombre");

            ViewBag.Pagos = new SelectList(
                await _context.Pagos.ToListAsync(),
                "Id",
                "Id");
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var tickets = await _ticketMensualService.GetAllAsync();
            return View(tickets);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            await CargarCombos();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(TicketMensualDto dto)
        {
            if (!ModelState.IsValid)
            {
                await CargarCombos();
                return View(dto);
            }

            bool existeUsuario = await _context.Usuarios
                .AnyAsync(u => u.Id == dto.UsuarioId);

            if (!existeUsuario)
            {
                ModelState.AddModelError("", "El usuario no existe.");
                await CargarCombos();
                return View(dto);
            }

            bool existePago = await _context.Pagos
                .AnyAsync(p => p.Id == dto.PagoId);

            if (!existePago)
            {
                ModelState.AddModelError("", "El pago no existe.");
                await CargarCombos();
                return View(dto);
            }

            try
            {
                await _ticketMensualService.AddAsync(dto);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                await CargarCombos();
                return View(dto);
            }
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var ticket = await _ticketMensualService.GetByIdAsync(id);

            if (ticket == null)
                return NotFound();

            return View(ticket);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var ticket = await _ticketMensualService.GetByIdAsync(id);

            if (ticket == null)
                return NotFound();

            await CargarCombos();
            return View(ticket);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(TicketMensualDto dto)
        {
            if (!ModelState.IsValid)
            {
                await CargarCombos();
                return View(dto);
            }

            bool existeUsuario = await _context.Usuarios
                .AnyAsync(u => u.Id == dto.UsuarioId);

            if (!existeUsuario)
            {
                ModelState.AddModelError("", "El usuario no existe.");
                await CargarCombos();
                return View(dto);
            }

            bool existePago = await _context.Pagos
                .AnyAsync(p => p.Id == dto.PagoId);

            if (!existePago)
            {
                ModelState.AddModelError("", "El pago no existe.");
                await CargarCombos();
                return View(dto);
            }

            try
            {
                await _ticketMensualService.UpdateAsync(dto);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                await CargarCombos();
                return View(dto);
            }
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var ticket = await _ticketMensualService.GetByIdAsync(id);

            if (ticket == null)
                return NotFound();

            return View(ticket);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            try
            {
                await _ticketMensualService.DeleteAsync(id);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);

                var ticket = await _ticketMensualService.GetByIdAsync(id);
                return View(ticket);
            }
        }
    }
}