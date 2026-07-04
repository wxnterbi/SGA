namespace SGA.Application.Dtos.Notificacion
{
    public class NotificacionDto
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public int TipoEvento { get; set; }
        public string Mensaje { get; set; }
        public DateTime FechaHora { get; set; }
    }
}
