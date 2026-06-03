using SGA.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGA.Domain.Entities.Reservation
{
    internal class Incidencia : AuditEntity
    {
        public int Id { get; set; }
        public int ViajeId { get; set; }
        public int ConductorId { get; set; }
        public string Tipo { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaHora { get; set; }
    }
}