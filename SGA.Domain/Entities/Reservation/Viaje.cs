using SGA.Domain.Base;

namespace SGA.Domain.Entities.Reservation
{
    public class Viaje : AuditEntity
    {
        public int Id { get; set; }
        public int RutaId { get; set; }
        public int HorarioId { get; set; }
        public int AutobusId { get; set; }
        public int ConductorId { get; set; }
        public string Estado { get; set; }
        public DateTime? HoraInicioReal { get; set; }
        public DateTime? HoraFinReal { get; set; }
    }
}
