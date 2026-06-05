using SGA.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGA.Domain.Entities.Reservation
{
    public class RegistroAcceso : AuditEntity
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public int ViajeId { get; set; }
        public bool Permitido { get; set; }
        public string Motivo { get; set; }
        public DateTime FechaHora { get; set; }
    }
}
