using SGA.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGA.Domain.Entities.Reservation
{
    public class TarjetaRecargable : AuditEntity
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public decimal Saldo { get; set; }
        public string Estado { get; set; }
    }
}
