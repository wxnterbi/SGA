using System;

namespace SGA.Application.Dtos.Conductor
{
    public class UpdateConductorDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string Licencia { get; set; }
        public string Telefono { get; set; }
        public int EstadoConductorId { get; set; }
    }
}