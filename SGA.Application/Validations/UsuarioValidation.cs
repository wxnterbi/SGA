using System.ComponentModel.DataAnnotations;

namespace SGA.Application.Validations
{
    public class UsuarioValidation
    {
        [Required(ErrorMessage = "El nombre de usuario es obligatorio.")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "El nombre debe tener entre 3 y 100 caracteres.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "La matrícula o identificación es obligatoria.")]
        [StringLength(20, ErrorMessage = "La identificación no puede superar los 20 caracteres.")]
        public string Identificacion { get; set; }
    }
}