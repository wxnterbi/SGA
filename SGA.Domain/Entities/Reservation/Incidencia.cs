using SGA.Domain.Base;
using SGA.Domain.Enums.Reservation;

namespace SGA.Domain.Entities.Reservation
{
    public class Incidencia : AuditEntity
    {
        public int Id { get; set; }
        public int ViajeId { get; set; }
        public int ConductorId { get; set; }
        public TipoIncidencia Tipo { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaHora { get; set; }
    }
}