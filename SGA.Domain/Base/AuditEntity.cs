namespace SGA.Domain.Base
{
    public class AuditEntity
    {
        public DateTime FechaCreacion { get; set; }

        public DateTime? FechaModificacion { get; set; }
    }
}