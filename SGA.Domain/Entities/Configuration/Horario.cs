using SGA.Domain.Base;

namespace SGA.Domain.Entities.Configuration
{
    public class Horario : AuditEntity
    {
        public int Id { get; set; }
        public string DiasOperacion { get; set; }
        public TimeSpan HoraSalida { get; set; }
        public int RutaId { get; set; }
    }
}
