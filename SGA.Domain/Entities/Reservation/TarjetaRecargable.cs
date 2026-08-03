using SGA.Domain.Base;
using SGA.Domain.Entities.Configuration;

namespace SGA.Domain.Entities.Reservation
{
    public class TarjetaRecargable : AuditEntity
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public decimal Saldo { get; set; }
        public Usuario Usuario { get; set; }
    }
}
