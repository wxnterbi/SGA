using System.ComponentModel.DataAnnotations;

namespace SGA.Application.Validations
{
    public class PagoValidation
    {
        [Required(ErrorMessage = "El monto de pago es obligatorio.")]
        [Range(0.01, 10000.00, ErrorMessage = "El monto de pago debe ser mayor a cero.")]
        public decimal Monto { get; set; }

        [Required(ErrorMessage = "La modalidad de pago es obligatoria.")]
        [StringLength(50, ErrorMessage = "La modalidad de pago es muy larga.")]
        public string MediodoPago { get; set; }
    }
}