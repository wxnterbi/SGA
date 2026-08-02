using Microsoft.AspNetCore.Mvc;
using SGA.Application.Dtos.Conductor;
using SGA.Application.Interfaces;

namespace SGA.Web.Controllers
{
    public class ConductorController : Controller
    {
        private readonly IConductorService _conductorService;

        public ConductorController(IConductorService conductorService)
        {
            _conductorService = conductorService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var conductores = await _conductorService.GetAllAsync();
            return View(conductores);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(ConductorDto dto)
        {
            if (!ModelState.IsValid)
                return View(dto);

            try
            {
                await _conductorService.AddAsync(dto);
                return RedirectToAction(nameof(Index));
            }
            catch (InvalidOperationException ex)
            {
                if (ex.Message == "CEDULA_DUPLICADA")
                    ModelState.AddModelError("Cedula", "La cédula ya está registrada para otro conductor.");
                else if (ex.Message == "TELEFONO_DUPLICADO")
                    ModelState.AddModelError("Telefono", "El número de teléfono ya está registrado.");

                return View(dto);
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
            var conductor = await _conductorService.GetByIdAsync(id);

            if (conductor == null)
                return NotFound();

            return View(conductor);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var conductor = await _conductorService.GetByIdAsync(id);

            if (conductor == null)
                return NotFound();

            return View(conductor);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(ConductorDto dto)
        {
            if (!ModelState.IsValid)
                return View(dto);

            try
            {
                await _conductorService.UpdateAsync(dto);
                return RedirectToAction(nameof(Index));
            }
            catch (InvalidOperationException ex)
            {
                if (ex.Message == "CEDULA_DUPLICADA")
                    ModelState.AddModelError("Cedula", "La cédula ingresada ya pertenece a otro conductor.");
                else if (ex.Message == "TELEFONO_DUPLICADO")
                    ModelState.AddModelError("Telefono", "El teléfono ingresado ya pertenece a otro conductor.");

                return View(dto);
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
            var conductor = await _conductorService.GetByIdAsync(id);

            if (conductor == null)
                return NotFound();

            return View(conductor);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            try
            {
                await _conductorService.DeleteAsync(id);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);

                var conductor = await _conductorService.GetByIdAsync(id);
                return View(conductor);
            }
        }
    }
}
