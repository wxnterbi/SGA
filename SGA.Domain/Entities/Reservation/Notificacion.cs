using SGA.Domain.Base;
using SGA.Domain.Enums.Reservation;

namespace SGA.Domain.Entities.Reservation
{
    public class Notificacion : AuditEntity
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public TipoEvento TipoEvento { get; set; }
        public string Mensaje { get; set; }
        public DateTime FechaHora { get; set; }
    }
}
