using Microsoft.AspNetCore.Mvc;
using SGA.Web.Interfaces.TicketMensual;
using SGA.Web.Models.TicketMensual;

namespace SGA.Web.Controllers
{
    public class TicketMensualController : Controller
    {
        private readonly ITicketMensualApiService _ticketMensualApiService;

        public TicketMensualController(ITicketMensualApiService ticketMensualApiService)
        {
            _ticketMensualApiService = ticketMensualApiService;
        }

        // GET: TicketMensual
        public async Task<IActionResult> Index()
        {
            var tickets = await _ticketMensualApiService.GetAllAsync();
            return View(tickets);
        }

        // GET: TicketMensual/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var ticket = await _ticketMensualApiService.GetByIdAsync(id);

            if (ticket == null)
                return NotFound();

            return View(ticket);
        }

        // GET: TicketMensual/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TicketMensual/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TicketMensualViewModel ticket)
        {
            if (!ModelState.IsValid)
                return View(ticket);

            var resultado = await _ticketMensualApiService.CreateAsync(ticket);

            if (!resultado)
            {
                ViewBag.Error = "No se pudo registrar el ticket mensual.";
                return View(ticket);
            }

            return RedirectToAction(nameof(Index));
        }

        // GET: TicketMensual/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var ticket = await _ticketMensualApiService.GetByIdAsync(id);

            if (ticket == null)
                return NotFound();

            return View(ticket);
        }

        // POST: TicketMensual/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(TicketMensualViewModel ticket)
        {
            if (!ModelState.IsValid)
                return View(ticket);

            var resultado = await _ticketMensualApiService.UpdateAsync(ticket);

            if (!resultado)
            {
                ViewBag.Error = "No se pudo actualizar el ticket mensual.";
                return View(ticket);
            }

            return RedirectToAction(nameof(Index));
        }

        // GET: TicketMensual/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var ticket = await _ticketMensualApiService.GetByIdAsync(id);

            if (ticket == null)
                return NotFound();

            return View(ticket);
        }

        // POST: TicketMensual/Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var resultado = await _ticketMensualApiService.DeleteAsync(id);

            if (!resultado)
            {
                ViewBag.Error = "No se pudo eliminar el ticket mensual.";
                return View();
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
