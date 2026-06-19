using SGA.Domain.Base;

namespace SGA.Domain.Entities.Reservation
{
    public class Pago : AuditEntity
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public decimal Monto { get; set; }
        public DateTime FechaPago { get; set; }
        public string Modalidad { get; set; }
    }
}
