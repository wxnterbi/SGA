namespace SGA.Application.Dtos.Incidencia
{
    public class UpdateIncidenciaDto
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public int EstadoIncidenciaId { get; set; }
    }
}