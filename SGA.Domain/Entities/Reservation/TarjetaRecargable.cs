using SGA.Domain.Base;
using SGA.Domain.Enums.Reservation;

namespace SGA.Domain.Entities.Reservation
{
    public class TarjetaRecargable : AuditEntity
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public decimal Saldo { get; set; }
        public EstadoTarjeta Estado { get; set; }
    }
}
