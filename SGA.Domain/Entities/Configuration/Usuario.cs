using SGA.Domain.Base;
using SGA.Domain.Enums.Configuration;

namespace SGA.Domain.Entities.Configuration
{
    public class Usuario : AuditEntity
    {
        public int Id { get; set; }
        public string IdentificadorInstitucional { get; set; }
        public string Nombre { get; set; }
        public TipoUsuario TipoUsuario { get; set; }
        public EstadoUsuario Estado { get; set; }
    }
}
