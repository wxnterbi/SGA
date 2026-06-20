using SGA.Domain.Base;
using SGA.Domain.Enums.Reservation;

namespace SGA.Domain.Entities.Reservation
{
    public class TicketMensual : AuditEntity
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public int PagoId { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public EstadoTicket Estado { get; set; }
    }
}