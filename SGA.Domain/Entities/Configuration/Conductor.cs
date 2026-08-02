using SGA.Domain.Base;
using SGA.Domain.Enums.Configuration;

namespace SGA.Domain.Entities.Configuration
{
    public class Conductor : AuditEntity
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string Licencia { get; set; }
        public string Telefono { get; set; }
        public EstadoLaboral EstadoLaboral { get; set; }
    }
}
