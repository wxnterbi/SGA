using SGA.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGA.Domain.Entities.Configuration
{
    internal class Usuario : AuditEntity
    {
        public int Id { get; set; }
        public string IdentificadorInstitucional { get; set; }
        public string Nombre { get; set; }
        public string TipoUsuario { get; set; }
        public string Estado { get; set; }
    }
}
