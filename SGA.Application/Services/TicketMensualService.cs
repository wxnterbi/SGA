using SGA.Application.BusinessRules;
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

            return tickets.Select(t => new TicketMensualDto
            {
                Id = t.Id,
                UsuarioId = t.UsuarioId,
                PagoId = t.PagoId,
                FechaInicio = t.FechaInicio,
                FechaFin = t.FechaFin,
                Estado = (int)t.Estado
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
                FechaInicio = ticket.FechaInicio,
                FechaFin = ticket.FechaFin,
                Estado = (int)ticket.Estado
            };
        }

        public async Task AddAsync(TicketMensualDto dto)
        {

            var ticket = new TicketMensual
            {
                UsuarioId = dto.UsuarioId,
                PagoId = dto.PagoId,
                FechaInicio = dto.FechaInicio,
                FechaFin = dto.FechaFin,
                Estado = (EstadoTicket)dto.Estado
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
            ticket.FechaInicio = dto.FechaInicio;
            ticket.FechaFin = dto.FechaFin;
            ticket.Estado = (EstadoTicket)dto.Estado;

            await _ticketRepository.UpdateAsync(ticket);
        }

        public async Task DeleteAsync(int id)
        {
            var ticket = await _ticketRepository.GetByIdAsync(id);

            if (ticket == null)
                throw new Exception("No se encontró el ticket mensual.");

            await _ticketRepository.DeleteAsync(id);
        }
    }
}
