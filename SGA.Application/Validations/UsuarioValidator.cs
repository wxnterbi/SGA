using FluentValidation;
using SGA.Application.Dtos.Usuario;

namespace SGA.Application.Validations
{
    public class UsuarioValidator : AbstractValidator<CreateUsuarioDto>
    {
        public UsuarioValidator()
        {
            RuleFor(x => x.IdentificadorInstitucional)
                .NotEmpty()
                .WithMessage("El identificador institucional es obligatorio.")
                .MinimumLength(8)
                .WithMessage("El identificador debe tener al menos 8 caracteres.")
                .MaximumLength(8)
                .WithMessage("El identificador no puede exceder los 8 caracteres.");

            RuleFor(x => x.Nombre)
                .NotEmpty()
                .WithMessage("El nombre es obligatorio.")
                .MaximumLength(60)
                .WithMessage("El nombre no puede exceder los 60 caracteres.");

            RuleFor(x => x.Contrasena)
                .NotEmpty()
                .WithMessage("La contraseña es obligatoria.")
                .MinimumLength(6)
                .WithMessage("La contraseña debe tener al menos 6 caracteres.")
                .MaximumLength(20)
                .WithMessage("La contraseña no puede exceder los 20 caracteres.");

            RuleFor(x => x.TipoUsuario)
                .IsInEnum()
                .WithMessage("Debe seleccionar un tipo de usuario válido.");

            RuleFor(x => x.Estado)
                .IsInEnum()
                .WithMessage("Debe seleccionar un estado de usuario válido.");
        }
    }
}