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

        public decimal Precio { get; set; }

        public DateTime FechaCompra { get; set; }

        public string Matricula { get; set; } = string.Empty;

        public string RutaEntrada { get; set; } = string.Empty;

        public string HorarioEntrada { get; set; } = string.Empty;

        public string ParadaEntrada { get; set; } = string.Empty;

        public string RutaSalida { get; set; } = string.Empty;

        public string HorarioSalida { get; set; } = string.Empty;

        public string ParadaSalida { get; set; } = string.Empty;

        public bool Vigente => FechaFin.Date >= DateTime.Today;

        public int DiasRestantes =>
    (FechaFin.Date - DateTime.Today).Days;
    }
}