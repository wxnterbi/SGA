using SGA.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGA.Domain.Entities.Reservation
{
    internal class TicketMensual : AuditEntity
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public int PagoId { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Estado { get; set; }
    }
}