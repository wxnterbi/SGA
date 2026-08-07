using System.ComponentModel.DataAnnotations;

namespace SGA.Application.Dtos.TarjetaRecargable
{
    public class RecargarSaldoDto
    {
        [Required(ErrorMessage = "El usuario es obligatorio.")]
        public int UsuarioId { get; set; }

        [Required(ErrorMessage = "El monto es obligatorio.")]
        [Range(1, 100000, ErrorMessage = "El monto debe ser mayor que cero.")]
        public decimal Monto { get; set; }

        [Required(ErrorMessage = "Debe seleccionar un tipo de pago.")]
        public string TipoPago { get; set; } = string.Empty;
    }
}