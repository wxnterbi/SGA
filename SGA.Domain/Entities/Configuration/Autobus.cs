using SGA.Domain.Base;
using SGA.Domain.Enums.Configuration;

namespace SGA.Domain.Entities.Configuration
{
    public class Autobus : AuditEntity
    {
        public int Id { get; set; }
        public string Placa { get; set; }
        public int CapacidadMaxima { get; set; }
        public EstadoAutobus EstadoOperativo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
    }
}
