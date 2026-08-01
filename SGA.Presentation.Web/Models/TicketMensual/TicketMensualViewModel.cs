namespace SGA.Web.Models.TicketMensual
{
    public class TicketMensualViewModel
    {
        public int Id { get; set; }

        public int UsuarioId { get; set; }

        public int PagoId { get; set; }

        public DateTime FechaInicio { get; set; }

        public DateTime FechaFin { get; set; }

        public int Estado { get; set; }
    }
}