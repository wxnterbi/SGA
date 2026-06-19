using SGA.Domain.Base;

namespace SGA.Domain.Entities.Configuration
{
    public class Usuario : AuditEntity
    {
        public int Id { get; set; }
        public string IdentificadorInstitucional { get; set; }
        public string Nombre { get; set; }
        public string TipoUsuario { get; set; }
        public string Estado { get; set; }
    }
}
