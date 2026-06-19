using SGA.Domain.Base;

namespace SGA.Domain.Entities.Configuration
{
    public class Parada : AuditEntity
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Ubicacion { get; set; }
        public int Orden { get; set; }
    }
}