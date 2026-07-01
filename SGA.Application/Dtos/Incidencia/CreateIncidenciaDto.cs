using System;

namespace SGA.Application.Dtos.Incidencia
{
    public class CreateIncidenciaDto
    {
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        public int AutobusId { get; set; }
        public int? ConductorId { get; set; }
        public int EstadoIncidenciaId { get; set; }
    }
}