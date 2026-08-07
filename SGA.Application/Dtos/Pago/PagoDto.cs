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
        public int? RutaEntradaId { get; set; }

        public int? HorarioEntradaId { get; set; }

        public int? ParadaEntradaId { get; set; }

        public int? RutaSalidaId { get; set; }

        public int? HorarioSalidaId { get; set; }

        public int? ParadaSalidaId { get; set; }

        public string? NombreRutaEntrada { get; set; }
        public string? NombreHorarioEntrada { get; set; }
        public string? NombreParadaEntrada { get; set; }

        public string? NombreRutaSalida { get; set; }
        public string? NombreHorarioSalida { get; set; }
        public string? NombreParadaSalida { get; set; }
    }
}
