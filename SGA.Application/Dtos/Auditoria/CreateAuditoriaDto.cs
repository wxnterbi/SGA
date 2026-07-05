namespace SGA.Application.Dtos.Auditoria
{
    public class CreateAuditoriaDto
    {
        public string Actor { get; set; }
        public string TipoAccion { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaHora { get; set; }
    }
}