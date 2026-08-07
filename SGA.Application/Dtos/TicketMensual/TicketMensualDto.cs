namespace SGA.Application.Dtos.TicketMensual
{
    public class TicketMensualDto
    {
        public int Id { get; set; }

        public int UsuarioId { get; set; }

        public int PagoId { get; set; }

        public decimal Precio { get; set; }

        public DateTime FechaInicio { get; set; }

        public DateTime FechaFin { get; set; }

        public int Estado { get; set; }

        public int? RutaEntradaId { get; set; }
        public int? HorarioEntradaId { get; set; }
        public int? ParadaEntradaId { get; set; }

        public int? RutaSalidaId { get; set; }
        public int? HorarioSalidaId { get; set; }
        public int? ParadaSalidaId { get; set; }
    }
}
