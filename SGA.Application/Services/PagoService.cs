using SGA.Application.BusinessRules;
using SGA.Application.Dtos.Pago;
using SGA.Application.Dtos.TicketMensual;
using SGA.Application.Interfaces;
using SGA.Domain.Entities.Reservation;
using SGA.Domain.Enums.Reservation;
using SGA.Infrastructure.Notifications;
using SGA.Persistence.Interfaces;
using SGA.Application.Dtos.Notificacion;

namespace SGA.Application.Services
{
    public class PagoService : IPagoService
    {
        private readonly IPagoRepository _pagoRepository;
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly UsuarioRules _usuarioRules;
        private readonly INotificationService _notificationService;
        private readonly ITarjetaRecargableService _tarjetaService;
        private readonly ITicketMensualService _ticketMensualService;
        private readonly ITicketMensualRepository _ticketRepository;
        private readonly INotificacionService _notificacionService;
        private readonly IRutaRepository _rutaRepository;
        private readonly IHorarioRepository _horarioRepository;
        private readonly IParadaRepository _paradaRepository;

        public PagoService(
            IPagoRepository pagoRepository,
            IUsuarioRepository usuarioRepository,
            UsuarioRules usuarioRules,
            INotificationService notificationService,
            ITarjetaRecargableService tarjetaService,
            ITicketMensualService ticketMensualService,
            ITicketMensualRepository ticketRepository,
            INotificacionService notificacionService,
            IRutaRepository rutaRepository,
            IHorarioRepository horarioRepository,
            IParadaRepository paradaRepository
            )
        {
            _pagoRepository = pagoRepository;
            _usuarioRepository = usuarioRepository;
            _usuarioRules = usuarioRules;
            _notificationService = notificationService;
            _tarjetaService = tarjetaService;
            _ticketMensualService = ticketMensualService;
            _ticketRepository = ticketRepository;
            _notificacionService = notificacionService;
            _rutaRepository = rutaRepository;
            _horarioRepository = horarioRepository;
            _paradaRepository = paradaRepository;
        }

        public async Task<IEnumerable<PagoDto>> GetAllAsync()
        {
            var pagos = await _pagoRepository.GetAllAsync();

            var resultado = new List<PagoDto>();

            foreach (var pago in pagos)
            {
                var usuario = _usuarioRepository.GetById(pago.UsuarioId);

                resultado.Add(new PagoDto
                {
                    Id = pago.Id,
                    UsuarioId = pago.UsuarioId,
                    IdentificadorInstitucional =
                        usuario?.IdentificadorInstitucional ?? "",
                    Monto = pago.Monto,
                    FechaPago = pago.FechaPago,
                    Modalidad = pago.Modalidad,
                    Concepto = pago.Concepto,
                    TipoTicket = pago.TipoTicket
                });
            }

            return resultado;
        }

        public async Task<IEnumerable<PagoDto>> GetRecargasAsync()
        {
            var pagos = await _pagoRepository.GetAllAsync();

            var resultado = new List<PagoDto>();

            foreach (var pago in pagos.Where(p => p.Concepto == ConceptoPago.Recarga))
            {
                var usuario = _usuarioRepository.GetById(pago.UsuarioId);

                resultado.Add(new PagoDto
                {
                    Id = pago.Id,
                    UsuarioId = pago.UsuarioId,
                    IdentificadorInstitucional =
                        usuario?.IdentificadorInstitucional ?? "",
                    Monto = pago.Monto,
                    FechaPago = pago.FechaPago,
                    Modalidad = pago.Modalidad,
                    Concepto = pago.Concepto,
                    TipoTicket = pago.TipoTicket
                });
            }

            return resultado
                .OrderByDescending(p => p.FechaPago)
                .ToList();
        }

        public async Task<PagoDto?> GetByIdAsync(int id)
        {
            var pago = await _pagoRepository.GetByIdAsync(id);

            if (pago == null)
                return null;

            var usuario = _usuarioRepository.GetById(pago.UsuarioId);

            var rutaEntrada = pago.RutaEntradaId.HasValue
                ? await _rutaRepository.GetByIdAsync(pago.RutaEntradaId.Value)
                : null;

            var horarioEntrada = pago.HorarioEntradaId.HasValue
                ? _horarioRepository.GetById(pago.HorarioEntradaId.Value)
                : null;

            var paradaEntrada = pago.ParadaEntradaId.HasValue
                ? _paradaRepository.GetById(pago.ParadaEntradaId.Value)
                : null;

            var rutaSalida = pago.RutaSalidaId.HasValue
                ? await _rutaRepository.GetByIdAsync(pago.RutaSalidaId.Value)
                : null;

            var horarioSalida = pago.HorarioSalidaId.HasValue
                ? _horarioRepository.GetById(pago.HorarioSalidaId.Value)
                : null;

            var paradaSalida = pago.ParadaSalidaId.HasValue
                ? _paradaRepository.GetById(pago.ParadaSalidaId.Value)
                : null;

            return new PagoDto



            {
                Id = pago.Id,
                UsuarioId = pago.UsuarioId,
                IdentificadorInstitucional = usuario?.IdentificadorInstitucional ?? "",
                Monto = pago.Monto,
                FechaPago = pago.FechaPago,
                Modalidad = pago.Modalidad,
                Concepto = pago.Concepto,
                TipoTicket = pago.TipoTicket,

                RutaEntradaId = pago.RutaEntradaId,
                HorarioEntradaId = pago.HorarioEntradaId,
                ParadaEntradaId = pago.ParadaEntradaId,

                RutaSalidaId = pago.RutaSalidaId,
                HorarioSalidaId = pago.HorarioSalidaId,
                ParadaSalidaId = pago.ParadaSalidaId,

                NombreRutaEntrada = rutaEntrada?.Nombre,
                NombreHorarioEntrada = horarioEntrada?.HoraSalida.ToString(@"hh\:mm"),
                NombreParadaEntrada = paradaEntrada?.Nombre,

                NombreRutaSalida = rutaSalida?.Nombre,
                NombreHorarioSalida = horarioSalida?.HoraSalida.ToString(@"hh\:mm"),
                NombreParadaSalida = paradaSalida?.Nombre,
            };
        }

        public async Task AddAsync(PagoDto dto)
        {

            var usuario = _usuarioRepository.GetById(dto.UsuarioId);

            _usuarioRules.ValidarUsuarioRegistrado(usuario != null);

            var pago = new Pago
            {
                UsuarioId = dto.UsuarioId,
                Monto = dto.Monto,
                FechaPago = dto.FechaPago,
                Modalidad = dto.Modalidad,
                Concepto = dto.Concepto,
                TipoTicket = dto.TipoTicket
            };

            await _pagoRepository.AddAsync(pago);

            await _notificationService.SendNotificationAsync(
               "estudiante@itla.edu.do",
               "Pago registrado",
               "Su pago fue registrado correctamente.");
        }

        public async Task UpdateAsync(PagoDto dto)
        {

            var pago = await _pagoRepository.GetByIdAsync(dto.Id);

            if (pago == null)
                throw new Exception("Pago no encontrado.");

            var usuario = _usuarioRepository.GetById(dto.UsuarioId);

            _usuarioRules.ValidarUsuarioRegistrado(usuario != null);

            pago.UsuarioId = dto.UsuarioId;
            pago.Monto = dto.Monto;
            pago.FechaPago = dto.FechaPago;
            pago.Modalidad = dto.Modalidad;
            pago.Concepto = dto.Concepto;
            pago.TipoTicket = dto.TipoTicket;

            await _pagoRepository.UpdateAsync(pago);
        }
        public async Task DeleteAsync(int id)
        {
            var pago = await _pagoRepository.GetByIdAsync(id);

            if (pago == null)
                throw new Exception("Pago no encontrado.");

            await _pagoRepository.DeleteAsync(id);
        }
        public async Task ComprarTicketAsync(ComprarTicketDto dto)
        {

            var ticketActivo = await _ticketRepository.GetActivoByUsuarioAsync(dto.UsuarioId);

            if (ticketActivo != null)
            {
                if (dto.EsMensual)
                {
                    throw new Exception(
                        $"Ya tienes un ticket mensual activo hasta {ticketActivo.FechaFin:dd/MM/yyyy}.");
                }

                bool mismaRuta =
                    (ticketActivo.RutaEntradaId.HasValue &&
                     ticketActivo.RutaEntradaId == dto.RutaEntradaId)
                    ||
                    (ticketActivo.RutaSalidaId.HasValue &&
                     ticketActivo.RutaSalidaId == dto.RutaSalidaId);

                if (mismaRuta)
                {
                    throw new Exception(
                        "Ya tienes un ticket mensual para esa ruta.");
                }
            }

            decimal monto;

            if (dto.EsMensual)
            {
                monto = 850;
            }
            else
            {
                monto = dto.TipoTicket switch
                {
                    TipoTicket.Entrada => 25,
                    TipoTicket.Salida => 25,
                    TipoTicket.EntradaYSalida => 50,
                    _ => throw new Exception("Tipo de ticket inválido.")
                };
            }        

            var saldo = await _tarjetaService.ObtenerSaldoAsync(dto.UsuarioId);

            if (saldo < monto)
                throw new Exception("Saldo insuficiente.");

            await _tarjetaService.DescontarSaldoAsync(dto.UsuarioId, monto);

            var pago = new Pago
            {
                UsuarioId = dto.UsuarioId,
                Monto = monto,
                FechaPago = DateTime.Now,
                Modalidad = "Tarjeta Recargable",
                Concepto = ConceptoPago.CompraTicket,
                TipoTicket = dto.TipoTicket,

                RutaEntradaId = dto.RutaEntradaId,
                HorarioEntradaId = dto.HorarioEntradaId,
                ParadaEntradaId = dto.ParadaEntradaId,

                RutaSalidaId = dto.RutaSalidaId,
                HorarioSalidaId = dto.HorarioSalidaId,
                ParadaSalidaId = dto.ParadaSalidaId
            };

            await _pagoRepository.AddAsync(pago);

            if (dto.EsMensual)
            {
                await _ticketMensualService.AddAsync(new TicketMensualDto
                {
                    UsuarioId = dto.UsuarioId,
                    PagoId = pago.Id,

                    FechaInicio = DateTime.Today,
                    FechaFin = DateTime.Today.AddMonths(1),

                    Estado = (int)EstadoTicket.Activo,

                    RutaEntradaId = dto.RutaEntradaId,
                    HorarioEntradaId = dto.HorarioEntradaId,
                    ParadaEntradaId = dto.ParadaEntradaId,

                    RutaSalidaId = dto.RutaSalidaId,
                    HorarioSalidaId = dto.HorarioSalidaId,
                    ParadaSalidaId = dto.ParadaSalidaId
                });
            }

            string descripcion = dto.EsMensual
                ? "ticket mensual"
                : $"ticket {dto.TipoTicket}";

            await _notificationService.SendNotificationAsync(
                "estudiante@itla.edu.do",
                "Compra realizada",
                $"Se compró correctamente el {descripcion}.");

            await _notificacionService.AddAsync(new NotificacionDto
            {
                UsuarioId = dto.UsuarioId,
                TipoEvento = 1,
                Mensaje = $"Se compró correctamente el {descripcion}.",
                FechaHora = DateTime.Now
            });
        }
    }
}
