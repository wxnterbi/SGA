namespace SGA.Web.Models.Pago

{
    public class PagoViewModel
    {
        public int Id { get; set; }

        public int UsuarioId { get; set; }

        public string IdentificadorInstitucional { get; set; } = string.Empty;

        public decimal Monto { get; set; }

        public DateTime FechaPago { get; set; }

        public string Modalidad { get; set; } = string.Empty;

        public string? NombreRutaEntrada { get; set; }

        public string? NombreHorarioEntrada { get; set; }

        public string? NombreParadaEntrada { get; set; }

        public string? NombreRutaSalida { get; set; }

        public string? NombreHorarioSalida { get; set; }

        public string? NombreParadaSalida { get; set; }

    }
}