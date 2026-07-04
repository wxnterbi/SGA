using SGA.Application.Dtos.TicketMensual;
using SGA.Application.Interfaces;
using SGA.Domain.Entities.Reservation;
using SGA.Domain.Enums.Reservation;
using SGA.Persistence.Interfaces;

namespace SGA.Application.Services
{
    public class TicketMensualService : ITicketMensualService
    {
        private readonly ITicketMensualRepository _ticketRepository;

        public TicketMensualService(ITicketMensualRepository ticketRepository)
        {
            _ticketRepository = ticketRepository;
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
            await _ticketRepository.DeleteAsync(id);
        }
    }
}
