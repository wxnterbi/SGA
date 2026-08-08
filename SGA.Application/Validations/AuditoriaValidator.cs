using FluentValidation;
using SGA.Application.Dtos.Auditoria;

namespace SGA.Application.Validations
{
    public class AuditoriaValidator
        : AbstractValidator<CreateAuditoriaDto>
    {
        public AuditoriaValidator()
        {
            RuleFor(x => x.Actor)
                .NotEmpty()
                .WithMessage("El actor es obligatorio.")

                .Must(x => !string.IsNullOrWhiteSpace(x))
                .WithMessage("El actor no puede estar vacío.")

                .MaximumLength(60)
                .WithMessage(
                    "El actor no puede exceder los 60 caracteres.");

            RuleFor(x => x.TipoAccion)
                .NotEmpty()
                .WithMessage(
                    "El tipo de acción es obligatorio.")

                .Must(x => !string.IsNullOrWhiteSpace(x))
                .WithMessage(
                    "El tipo de acción no puede estar vacío.")

                .MaximumLength(50)
                .WithMessage(
                    "El tipo de acción no puede exceder los 50 caracteres.");

            RuleFor(x => x.Descripcion)
                .NotEmpty()
                .WithMessage(
                    "La descripción es obligatoria.")

                .Must(x => !string.IsNullOrWhiteSpace(x))
                .WithMessage(
                    "La descripción no puede estar vacía.")

                .MaximumLength(500)
                .WithMessage(
                    "La descripción no puede exceder los 500 caracteres.");
        }
    }
}