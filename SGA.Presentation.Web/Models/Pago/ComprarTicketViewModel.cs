using System.ComponentModel.DataAnnotations;

namespace SGA.Web.Models.Pago
{
    public class ComprarTicketViewModel
    {
        [Required]
        public int UsuarioId { get; set; }

        public string IdentificadorInstitucional { get; set; } = string.Empty;

        public decimal Saldo { get; set; }

        [Required]
        public int TipoTicket { get; set; }

        public bool EsMensual { get; set; }

        public int? RutaEntradaId { get; set; }

        public int? HorarioEntradaId { get; set; }

        public int? ParadaEntradaId { get; set; }

        public int? RutaSalidaId { get; set; }

        public int? HorarioSalidaId { get; set; }

        public int? ParadaSalidaId { get; set; }

        public decimal Precio { get; set; }

        public List<RutaCompraViewModel> Rutas { get; set; }
            = new List<RutaCompraViewModel>();

        public List<HorarioCompraViewModel> Horarios { get; set; }
            = new List<HorarioCompraViewModel>();

        public List<ParadaCompraViewModel> Paradas { get; set; }
            = new List<ParadaCompraViewModel>();

    }
}
