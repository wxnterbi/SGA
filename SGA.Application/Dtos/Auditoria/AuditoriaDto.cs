namespace SGA.Application.Dtos.Auditoria
{
    public class AuditoriaDto
    {
        public int Id { get; set; }

        public string Actor { get; set; } = string.Empty;

        public string TipoAccion { get; set; } = string.Empty;

        public string Descripcion { get; set; } = string.Empty;

        public DateTime FechaHora { get; set; }
    }
}