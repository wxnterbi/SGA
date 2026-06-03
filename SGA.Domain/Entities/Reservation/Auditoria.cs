using SGA.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGA.Domain.Entities.Reservation
{
    internal class Auditoria : AuditEntity
    {
        public int Id { get; set; }
        public string Actor { get; set; }
        public string TipoAccion { get; set; }
        public DateTime FechaHora { get; set; }
    }
}