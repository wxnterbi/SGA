using System.ComponentModel.DataAnnotations;

namespace SGA.Web.Models.TarjetaRecargable
{
    public class RecargarSaldoViewModel
    {
        public int TarjetaId { get; set; }

        public int UsuarioId { get; set; }

        public decimal SaldoActual { get; set; }

        [Required(ErrorMessage = "Ingrese el monto.")]
        [Range(1, 5000, ErrorMessage = "El monto debe estar entre RD$1 y RD$5,000.")]
        public decimal Monto { get; set; }

        [Required(ErrorMessage = "Ingrese el número de tarjeta.")]
        [StringLength(19, MinimumLength = 19,
            ErrorMessage = "El número de tarjeta debe tener 16 dígitos.")]
        public string NumeroTarjeta { get; set; } = string.Empty;

        [Required(ErrorMessage = "Ingrese el nombre del titular.")]
        [RegularExpression(@"^[A-Za-zÁÉÍÓÚáéíóúÑñ ]+$",
            ErrorMessage = "Solo se permiten letras.")]
        public string NombreTitular { get; set; } = string.Empty;

        [Required(ErrorMessage = "Ingrese la fecha de expiración.")]
        [RegularExpression(@"^(0[1-9]|1[0-2])\/([0-9]{2})$",
            ErrorMessage = "Formato válido: MM/AA.")]
        public string FechaExpiracion { get; set; } = string.Empty;

        [Required(ErrorMessage = "Ingrese el CVV.")]
        [RegularExpression(@"^\d{3}$",
            ErrorMessage = "El CVV debe tener 3 dígitos.")]
        public string CVV { get; set; } = string.Empty;
    }
}