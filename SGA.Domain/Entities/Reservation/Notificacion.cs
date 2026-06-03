using SGA.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGA.Domain.Entities.Reservation
{
    internal class Notificacion : AuditEntity
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public string TipoEvento { get; set; }
        public DateTime FechaHora { get; set; }
    }
}
