using SGA.Domain.Base;

namespace SGA.Domain.Entities.Reservation
{
    public class Auditoria : AuditEntity
    {
        public int Id { get; set; }
        public string Actor { get; set; }
        public string TipoAccion { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaHora { get; set; }
    }
}