using SGA.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGA.Domain.Entities.Configuration
{
    public class Horario : AuditEntity
    {
        public int Id { get; set; }
        public string DiasOperacion { get; set; }
        public TimeSpan HoraSalida { get; set; }
        public int RutaId { get; set; }
    }
}
