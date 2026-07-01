using System;

namespace SGA.Application.Dtos.Incidencia
{
    public class IncidenciaDto
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        public int AutobusId { get; set; }
        public string PlacaAutobus { get; set; }
        public int? ConductorId { get; set; }
        public string NombreConductor { get; set; }
        public int EstadoIncidenciaId { get; set; }
        public string EstadoDescripcion { get; set; }
    }
}