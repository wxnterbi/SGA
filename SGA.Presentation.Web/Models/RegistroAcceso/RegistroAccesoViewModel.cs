namespace SGA.Web.Models.RegistroAcceso
{
    public class RegistroAccesoViewModel
    {
        public int Id { get; set; }

        public int UsuarioId { get; set; }

        public string Matricula { get; set; } = string.Empty;

        public int ViajeId { get; set; }

        public bool Permitido { get; set; }

        public string Motivo { get; set; } = string.Empty;

        public DateTime FechaHora { get; set; }
    }
}
