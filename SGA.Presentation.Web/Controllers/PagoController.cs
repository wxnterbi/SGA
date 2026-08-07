using Microsoft.AspNetCore.Mvc;
using SGA.Web.Interfaces.Pago;
using SGA.Web.Interfaces.TarjetaRecargable;
using SGA.Web.Models.Pago;
using System.Text.Json;

namespace SGA.Web.Controllers
{
    public class PagoController : Controller
    {
        private readonly IPagoApiService _pagoApiService;
        private readonly ITarjetaRecargableApiService _tarjetaService;

        public PagoController(
            IPagoApiService pagoApiService,
            ITarjetaRecargableApiService tarjetaService)
        {
            _pagoApiService = pagoApiService;
            _tarjetaService = tarjetaService;
        }

        // PAGOS
        public async Task<IActionResult> Index()
        {
            var pagos = await _pagoApiService.GetAllAsync();

            pagos = pagos
                .OrderByDescending(p => p.FechaPago)
                .ToList();

            return View(pagos);
        }

        // DETALLE
        public async Task<IActionResult> Details(int id)
        {
            var pago = await _pagoApiService.GetByIdAsync(id);

            if (pago == null)
                return NotFound();

            return View(pago);
        }

        // CREAR PAGO
        public IActionResult Create()
        {
            return View();
        }

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

        // EDITAR
        public async Task<IActionResult> Edit(int id)
        {
            var pago = await _pagoApiService.GetByIdAsync(id);

            if (pago == null)
                return NotFound();

            return View(pago);
        }

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

        // ELIMINAR
        public async Task<IActionResult> Delete(int id)
        {
            var pago = await _pagoApiService.GetByIdAsync(id);

            if (pago == null)
                return NotFound();

            return View(pago);
        }

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

        // COMPRAR TICKET - GET
        public async Task<IActionResult> ComprarTicket()
        {
            int usuarioId = 2; // Reemplazar luego por usuario logueado

            var tarjeta = await _tarjetaService.GetByUsuarioIdAsync(usuarioId);

            if (tarjeta == null)
                return NotFound();

            var model = new ComprarTicketViewModel
            {
                UsuarioId = tarjeta.UsuarioId,
                IdentificadorInstitucional = tarjeta.IdentificadorInstitucional,
                Saldo = tarjeta.Saldo
            };

            await CargarDatosTicket(model);

            return View(model);
        }

        // COMPRAR TICKET - POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ComprarTicket(
            ComprarTicketViewModel model)
        {
            if (model == null)
            {
                ModelState.AddModelError(
                    "",
                    "Los datos enviados no son válidos.");

                return View(model);
            }


            await CargarDatosTicket(model);

            if (model.UsuarioId <= 0)
            {
                ModelState.AddModelError(
                    "UsuarioId",
                    "Debe existir un usuario válido.");
            }


            if (!ModelState.IsValid)
                return View(model);

            var tarjeta = await _tarjetaService
                .GetByUsuarioIdAsync(model.UsuarioId);

            if (tarjeta == null)
            {
                ModelState.AddModelError(
                    "",
                    "No se encontró la tarjeta del usuario.");

                return View(model);
            }

            decimal precioReal = CalcularPrecio(model);

            if (precioReal <= 0)
            {
                ModelState.AddModelError(
                    "TipoTicket",
                    "Debe seleccionar un tipo de ticket válido.");

                return View(model);
            }
            if (tarjeta.Saldo < precioReal)
            {
                ModelState.AddModelError(
                    "",
                    $"Saldo insuficiente. " +
                    $"Saldo disponible: RD$ {tarjeta.Saldo:N2}. " +
                    $"Precio: RD$ {precioReal:N2}.");

                return View(model);
            }

            model.Precio = precioReal;
            model.Saldo = tarjeta.Saldo;
            model.IdentificadorInstitucional =
                tarjeta.IdentificadorInstitucional;

            var response =
                await _pagoApiService.ComprarTicketAsync(model);

            if (!response.IsSuccessStatusCode)
            {
                var json =
                    await response.Content.ReadAsStringAsync();

                ProcesarErroresApi(json);

                await CargarDatosTicket(model);

                return View(model);
            }

            TempData["Success"] =
                "Compra realizada correctamente.";

            return RedirectToAction(nameof(Index));
        }

        private void ProcesarErroresApi(string json)
        {
            if (string.IsNullOrWhiteSpace(json))
            {
                ModelState.AddModelError(
                    "",
                    "No se pudo procesar la compra.");

                return;
            }

            try
            {
                using var documento =
                    JsonDocument.Parse(json);

                var root = documento.RootElement;

                if (root.TryGetProperty(
                    "errors",
                    out var errores))
                {
                    foreach (
                        var error in errores.EnumerateObject())
                    {
                        foreach (
                            var mensaje
                            in error.Value.EnumerateArray())
                        {
                            var texto =
                                mensaje.GetString();

                            if (!string.IsNullOrWhiteSpace(texto))
                            {
                                ModelState.AddModelError(
                                    error.Name,
                                    texto);
                            }
                        }
                    }

                    return;
                }

                if (root.TryGetProperty(
                    "detail",
                    out var detalle))
                {
                    var mensaje =
                        detalle.GetString();

                    if (!string.IsNullOrWhiteSpace(mensaje))
                    {
                        ModelState.AddModelError(
                            "",
                            mensaje);
                    }

                    return;
                }

                if (root.TryGetProperty(
                    "title",
                    out var titulo))
                {
                    var mensaje =
                        titulo.GetString();

                    if (!string.IsNullOrWhiteSpace(mensaje))
                    {
                        ModelState.AddModelError(
                            "",
                            mensaje);
                    }

                    return;
                }
            }
            catch (JsonException)
            {
               
            }

            ModelState.AddModelError("", json);
        }

        // CARGAR RUTAS, HORARIOS Y PARADAS
        private async Task CargarDatosTicket(
            ComprarTicketViewModel model)
        {
            model.Rutas =
                await _pagoApiService.GetRutasAsync();

            model.Horarios =
                await _pagoApiService.GetHorariosAsync();

            model.Paradas =
                await _pagoApiService.GetParadasAsync();
        }

        // CALCULAR PRECIO
        private decimal CalcularPrecio(
            ComprarTicketViewModel model)
        {
            if (model.EsMensual)
                return 850;

            return model.TipoTicket switch
            {
                1 => 25,
                2 => 25,
                3 => 50,
                _ => 0
            };
        }
    }
}
