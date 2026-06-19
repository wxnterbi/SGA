using SGA.Domain.Base;

namespace SGA.Domain.Entities.Reservation
{
    public class Incidencia : AuditEntity
    {
        public int Id { get; set; }
        public int ViajeId { get; set; }
        public int ConductorId { get; set; }
        public string Tipo { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaHora { get; set; }
    }
}