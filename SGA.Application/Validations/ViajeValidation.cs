using System.ComponentModel.DataAnnotations;

namespace SGA.Application.Validations
{
    public class ViajeValidation
    {
        [Required(ErrorMessage = "El estado del viaje es obligatorio.")]
        [StringLength(30, ErrorMessage = "El estado no puede superar los 30 caracteres.")]
        public string Estado { get; set; }

        [Required(ErrorMessage = "La capacidad disponible debe ser definida.")]
        [Range(1, 100, ErrorMessage = "La capacidad del autobús debe estar entre 1 y 100 pasajeros.")]
        public int CapacidadMax { get; set; }
    }
}