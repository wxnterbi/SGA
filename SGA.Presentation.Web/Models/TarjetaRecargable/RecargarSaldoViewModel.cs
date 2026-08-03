using System.ComponentModel.DataAnnotations;

namespace SGA.Web.Models.TarjetaRecargable
{
    public class RecargarSaldoViewModel
    {
        public int TarjetaId { get; set; }

        public int UsuarioId { get; set; }

        public decimal SaldoActual { get; set; }

        [Required(ErrorMessage = "Ingrese el monto.")]
        [Range(1, 100000)]
        public decimal Monto { get; set; }

        [Required(ErrorMessage = "Ingrese el número de tarjeta.")]
        public string NumeroTarjeta { get; set; } = string.Empty;

        [Required(ErrorMessage = "Ingrese el nombre del titular.")]
        public string NombreTitular { get; set; } = string.Empty;

        [Required(ErrorMessage = "Ingrese la fecha de expiración.")]
        public string FechaExpiracion { get; set; } = string.Empty;

        [Required(ErrorMessage = "Ingrese el CVV.")]
        public string CVV { get; set; } = string.Empty;
    }
}