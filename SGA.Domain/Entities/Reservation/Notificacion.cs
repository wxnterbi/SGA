using SGA.Domain.Base;

namespace SGA.Domain.Entities.Reservation
{
    public class Notificacion : AuditEntity
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public string TipoEvento { get; set; }
        public string Mensaje { get; set; }
        public DateTime FechaHora { get; set; }
    }
}
