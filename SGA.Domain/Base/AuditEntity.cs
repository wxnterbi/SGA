using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGA.Domain.Base
{
    internal class AuditEntity
    {
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}