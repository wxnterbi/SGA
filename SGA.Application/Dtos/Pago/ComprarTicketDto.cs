using SGA.Domain.Enums.Reservation;
using System.ComponentModel.DataAnnotations;

namespace SGA.Application.Dtos.Pago
{
    public class ComprarTicketDto
    {
        [Required]
        public int UsuarioId { get; set; }

        [Required]
        public TipoTicket TipoTicket { get; set; }
        public bool EsMensual { get; set; }

        public int? RutaEntradaId { get; set; }

        public int? HorarioEntradaId { get; set; }

        public int? ParadaEntradaId { get; set; }

        public int? RutaSalidaId { get; set; }

        public int? HorarioSalidaId { get; set; }

        public int? ParadaSalidaId { get; set; }
    }
}