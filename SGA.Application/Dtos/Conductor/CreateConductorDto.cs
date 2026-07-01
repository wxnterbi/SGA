using System;

namespace SGA.Application.Dtos.Conductor
{
    public class CreateConductorDto
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }
        public string Licencia { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaContratacion { get; set; }
        public int EstadoConductorId { get; set; }
    }
}