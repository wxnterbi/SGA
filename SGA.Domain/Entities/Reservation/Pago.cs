using SGA.Domain.Base;
using SGA.Domain.Enums.Reservation;

namespace SGA.Domain.Entities.Reservation
{
    public class Pago : AuditEntity
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public decimal Monto { get; set; }
        public DateTime FechaPago { get; set; }
        public string Modalidad { get; set; }
        public ConceptoPago Concepto { get; set; }
        public TipoTicket? TipoTicket { get; set; }
        public int? RutaEntradaId { get; set; }

        public int? HorarioEntradaId { get; set; }

        public int? ParadaEntradaId { get; set; }

        public int? RutaSalidaId { get; set; }

        public int? HorarioSalidaId { get; set; }

        public int? ParadaSalidaId { get; set; }
    }
}
