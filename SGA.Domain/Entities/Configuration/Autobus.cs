using SGA.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGA.Domain.Entities.Configuration
{
    public class Autobus : AuditEntity
    {
        public int Id { get; set; }
        public string Placa { get; set; }
        public int CapacidadMaxima { get; set; }
        public string EstadoOperativo { get; set; }
    }
}
