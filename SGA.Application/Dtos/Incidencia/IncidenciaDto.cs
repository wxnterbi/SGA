using System;

namespace SGA.Application.Dtos.Incidencia
{
    public class IncidenciaDto
    {
        public int Id { get; set; } 
        public int ViajeId { get; set; }
        public int ConductorId { get; set; }
        public int Tipo { get; set; } 
        public string Descripcion { get; set; }
        public DateTime FechaHora { get; set; }
    }
}