using FluentValidation;
using SGA.Application.Dtos.Auditoria;

namespace SGA.Application.Validations
{
    public class AuditoriaValidator : AbstractValidator<AuditoriaDto>
    {
        public AuditoriaValidator()
        {
            RuleFor(x => x.Actor)
                .NotEmpty()
                .WithMessage("El actor es obligatorio.")
                .MaximumLength(60)
                .WithMessage("El actor no puede exceder los 60 caracteres.")
                .Must(actor => !string.IsNullOrWhiteSpace(actor))
                .WithMessage("El actor no puede estar vacío.");

            RuleFor(x => x.TipoAccion)
                .NotEmpty()
                .WithMessage("El tipo de acción es obligatorio.")
                .MaximumLength(50)
                .WithMessage("El tipo de acción no puede exceder los 50 caracteres.")
                .Must(tipo => !string.IsNullOrWhiteSpace(tipo))
                .WithMessage("El tipo de acción no puede estar vacío.");

            RuleFor(x => x.Descripcion)
                .NotEmpty()
                .WithMessage("La descripción es obligatoria.")
                .MaximumLength(500)
                .WithMessage("La descripción no puede exceder los 500 caracteres.")
                .Must(descripcion => !string.IsNullOrWhiteSpace(descripcion))
                .WithMessage("La descripción no puede estar vacía.");

            RuleFor(x => x.FechaHora)
                .NotEmpty()
                .WithMessage("La fecha y hora son obligatorias.");

            RuleFor(x => x.Id)
                .GreaterThanOrEqualTo(0)
                .WithMessage("El ID de la auditoría no puede ser negativo.");
        }
    }
}