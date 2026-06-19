using SGA.Domain.Base;

namespace SGA.Domain.Entities.Reservation
{
    public class TarjetaRecargable : AuditEntity
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public decimal Saldo { get; set; }
        public string Estado { get; set; }
    }
}
