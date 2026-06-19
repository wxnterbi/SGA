using SGA.Domain.Base;

namespace SGA.Domain.Entities.Configuration
{
    public class Conductor : AuditEntity
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Identificacion { get; set; }
        public string EstadoLaboral { get; set; }
    }
}
