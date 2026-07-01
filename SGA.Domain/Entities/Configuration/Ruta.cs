using SGA.Domain.Base;

namespace SGA.Domain.Entities.Configuration
{
    public class Ruta : AuditEntity
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }

    }
}
