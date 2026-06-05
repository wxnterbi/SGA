using SGA.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGA.Domain.Entities.Configuration
{
    public class Parada : AuditEntity
    {
        public int Id { get; set; }
        public int Orden { get; set; }
    }
}