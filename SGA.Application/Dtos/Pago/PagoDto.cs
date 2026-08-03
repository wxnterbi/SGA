using SGA.Domain.Enums.Reservation;

namespace SGA.Application.Dtos.Pago
{
    public class PagoDto
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public string IdentificadorInstitucional { get; set; } = string.Empty;
        public decimal Monto { get; set; }
        public DateTime FechaPago { get; set; }
        public string Modalidad { get; set; } = string.Empty;
        public ConceptoPago Concepto { get; set; }
        public TipoTicket? TipoTicket { get; set; }
    }
}
