namespace SGA.Application.Dtos.TicketMensual
{
    public class CreateTicketMensualDto
    {
        public int UsuarioId { get; set; }

        public int PagoId { get; set; }

        public DateTime FechaInicio { get; set; }

        public DateTime FechaFin { get; set; }

        public int Estado { get; set; }
    }
}
