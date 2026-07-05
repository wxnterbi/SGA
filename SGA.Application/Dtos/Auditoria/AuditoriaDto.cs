namespace SGA.Application.Dtos.Auditoria
{
    public class AuditoriaDto
    {
        public int Id { get; set; }
        public string Actor { get; set; }
        public string TipoAccion { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaHora { get; set; }
    }
}