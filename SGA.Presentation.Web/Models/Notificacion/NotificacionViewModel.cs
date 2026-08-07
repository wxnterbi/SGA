namespace SGA.Web.Models.Notificacion
{
    public class NotificacionViewModel
    {
        public int Id { get; set; }

        public int UsuarioId { get; set; }

        public int TipoEvento { get; set; }

        public string Mensaje { get; set; } = string.Empty;

        public DateTime FechaHora { get; set; }
    }
}
