using FluentValidation;
using SGA.Application.Dtos.Usuario;

namespace SGA.Application.Validations
{
    public class UsuarioValidator : AbstractValidator<UsuarioDto>
    {
        public UsuarioValidator()
        {
            RuleFor(x => x.IdentificadorInstitucional)
                .NotEmpty()
                .WithMessage("El identificador institucional es obligatorio.");

            RuleFor(x => x.Nombre)
                .NotEmpty()
                .WithMessage("El nombre es obligatorio.")
                .MaximumLength(60)
                .WithMessage("El nombre no puede exceder los 60 caracteres.");

            RuleFor(x => x.TipoUsuario)
                .IsInEnum()
                .WithMessage("Debe seleccionar un tipo de usuario válido.");

            RuleFor(x => x.Estado)
                .IsInEnum()
                .WithMessage("Debe seleccionar un estado de usuario válido.");
        }
    }
}