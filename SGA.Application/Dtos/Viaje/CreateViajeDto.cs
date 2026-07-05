using SGA.Domain.Enums.Reservation;

namespace SGA.Application.Dtos.Viaje
{
    public class CreateViajeDto
    {
        public int RutaId { get; set; }
        public int HorarioId { get; set; }
        public int AutobusId { get; set; }
        public int ConductorId { get; set; }
        public EstadoViaje Estado { get; set; }
        public DateTime? HoraInicioReal { get; set; }
        public DateTime? HoraFinReal { get; set; }
    }
}