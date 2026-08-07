using SGA.Application.BusinessRules;
using SGA.Application.Dtos.Pago;
using SGA.Application.Dtos.TicketMensual;
using SGA.Application.Interfaces;
using SGA.Domain.Entities.Reservation;
using SGA.Domain.Enums.Reservation;
using SGA.Infrastructure.Notifications;
using SGA.Persistence.Interfaces;
using SGA.Persistence.Repository;

namespace SGA.Application.Services
{
    public class TicketMensualService : ITicketMensualService
    {
        private readonly ITicketMensualRepository _ticketRepository;
        private readonly INotificationService _notificationService;

        public TicketMensualService(
            ITicketMensualRepository ticketRepository,
            INotificationService notificationService)
        {
            _ticketRepository = ticketRepository;
            _notificationService = notificationService;
        }

        public async Task<IEnumerable<TicketMensualDto>> GetAllAsync()
        {
            var tickets = await _ticketRepository.GetAllAsync();

            foreach (var ticket in tickets)
            {
                if (ticket.FechaFin.Date < DateTime.Today &&
                    ticket.Estado == EstadoTicket.Activo)
                {
                    ticket.Estado = EstadoTicket.Vencido;

                    await _ticketRepository.UpdateAsync(ticket);
                }
            }
            return tickets.Select(t => new TicketMensualDto
            {
                Id = t.Id,
                UsuarioId = t.UsuarioId,
                PagoId = t.PagoId,
                Precio = t.Precio,

                FechaInicio = t.FechaInicio,
                FechaFin = t.FechaFin,
                Estado = (int)t.Estado,

                RutaEntradaId = t.RutaEntradaId,
                HorarioEntradaId = t.HorarioEntradaId,
                ParadaEntradaId = t.ParadaEntradaId,

                RutaSalidaId = t.RutaSalidaId,
                HorarioSalidaId = t.HorarioSalidaId,
                ParadaSalidaId = t.ParadaSalidaId
            });
        }

        public async Task<TicketMensualDto?> GetByIdAsync(int id)
        {
            var ticket = await _ticketRepository.GetByIdAsync(id);

            if (ticket == null)
                return null;

            return new TicketMensualDto
            {
                Id = ticket.Id,
                UsuarioId = ticket.UsuarioId,
                PagoId = ticket.PagoId,
                Precio = ticket.Precio,

                FechaInicio = ticket.FechaInicio,
                FechaFin = ticket.FechaFin,
                Estado = (int)ticket.Estado,

                RutaEntradaId = ticket.RutaEntradaId,
                HorarioEntradaId = ticket.HorarioEntradaId,
                ParadaEntradaId = ticket.ParadaEntradaId,

                RutaSalidaId = ticket.RutaSalidaId,
                HorarioSalidaId = ticket.HorarioSalidaId,
                ParadaSalidaId = ticket.ParadaSalidaId
            };
        }

        public async Task AddAsync(TicketMensualDto dto)
        {

            var ticket = new TicketMensual
            {
                UsuarioId = dto.UsuarioId,
                PagoId = dto.PagoId,

                Precio = dto.Precio,

                FechaInicio = dto.FechaInicio,
                FechaFin = dto.FechaFin,
                Estado = (EstadoTicket)dto.Estado,

                RutaEntradaId = dto.RutaEntradaId,
                HorarioEntradaId = dto.HorarioEntradaId,
                ParadaEntradaId = dto.ParadaEntradaId,

                RutaSalidaId = dto.RutaSalidaId,
                HorarioSalidaId = dto.HorarioSalidaId,
                ParadaSalidaId = dto.ParadaSalidaId
            };

            await _ticketRepository.AddAsync(ticket);

            await _notificationService.SendNotificationAsync(
                "estudiante@itla.edu.do",
                "Ticket mensual generado",
                "Su ticket mensual fue generado correctamente.");
        }

        public async Task UpdateAsync(TicketMensualDto dto)
        {

            var ticket = await _ticketRepository.GetByIdAsync(dto.Id);

            if (ticket == null)
                throw new Exception("Ticket mensual no encontrado.");

            ticket.UsuarioId = dto.UsuarioId;
            ticket.PagoId = dto.PagoId;
            ticket.Precio = dto.Precio;

            ticket.FechaInicio = dto.FechaInicio;
            ticket.FechaFin = dto.FechaFin;
            ticket.Estado = (EstadoTicket)dto.Estado;

            ticket.RutaEntradaId = dto.RutaEntradaId;
            ticket.HorarioEntradaId = dto.HorarioEntradaId;
            ticket.ParadaEntradaId = dto.ParadaEntradaId;

            ticket.RutaSalidaId = dto.RutaSalidaId;
            ticket.HorarioSalidaId = dto.HorarioSalidaId;
            ticket.ParadaSalidaId = dto.ParadaSalidaId;


            await _ticketRepository.UpdateAsync(ticket);
        }

        public async Task DeleteAsync(int id)
        {
            var ticket = await _ticketRepository.GetByIdAsync(id);

            if (ticket == null)
                throw new Exception("No se encontró el ticket mensual.");

            await _ticketRepository.DeleteAsync(id);
        }
        public async Task CrearDesdeCompraAsync(int usuarioId, int pagoId, ComprarTicketDto dto)
        {
            var ticket = new TicketMensual
            {
                UsuarioId = usuarioId,
                PagoId = pagoId,

                Precio = 850,

                FechaInicio = DateTime.Today,
                FechaFin = DateTime.Today.AddMonths(1),

                Estado = EstadoTicket.Activo,

                RutaEntradaId = dto.RutaEntradaId,
                HorarioEntradaId = dto.HorarioEntradaId,
                ParadaEntradaId = dto.ParadaEntradaId,

                RutaSalidaId = dto.RutaSalidaId,
                HorarioSalidaId = dto.HorarioSalidaId,
                ParadaSalidaId = dto.ParadaSalidaId
            };

            await _ticketRepository.AddAsync(ticket);

            await _notificationService.SendNotificationAsync(
                "estudiante@itla.edu.do",
                "Ticket mensual",
                "Tu ticket mensual fue generado correctamente.");
        }
    }
}
