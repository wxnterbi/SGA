using FluentValidation;
using SGA.Application.Dtos.Conductor;

namespace SGA.Application.Validations
{
    public class ConductorValidator : AbstractValidator<ConductorDto>
    {
        public ConductorValidator()
        {
            RuleFor(x => x.Nombre)
                .NotEmpty()
                .WithMessage("El nombre del conductor es obligatorio.")
                .MaximumLength(60)
                .WithMessage("El nombre no puede exceder los 60 caracteres.")
                .Must(nombre => !string.IsNullOrWhiteSpace(nombre))
                .WithMessage("El nombre no puede estar vacío.");

            RuleFor(x => x.Cedula)
                .NotEmpty()
                .WithMessage("La cédula es obligatoria.")
                .MaximumLength(20)
                .WithMessage("La cédula no puede exceder los 20 caracteres.")
                .Must(cedula => !string.IsNullOrWhiteSpace(cedula))
                .WithMessage("La cédula no puede estar vacía.");

            RuleFor(x => x.Licencia)
                .NotEmpty()
                .WithMessage("La licencia es obligatoria.")
                .MaximumLength(30)
                .WithMessage("La licencia no puede exceder los 30 caracteres.")
                .Must(licencia => !string.IsNullOrWhiteSpace(licencia))
                .WithMessage("La licencia no puede estar vacía.");

            RuleFor(x => x.Telefono)
                .NotEmpty()
                .WithMessage("El teléfono es obligatorio.")
                .MaximumLength(20)
                .WithMessage("El teléfono no puede exceder los 20 caracteres.")
                .Must(telefono => !string.IsNullOrWhiteSpace(telefono))
                .WithMessage("El teléfono no puede estar vacío.");

            RuleFor(x => x.FechaContratacion)
                .LessThanOrEqualTo(DateTime.Today)
                .WithMessage("La fecha de contratación no puede ser futura.");

            RuleFor(x => x.EstadoConductorId)
                .GreaterThan(0)
                .WithMessage("Debe seleccionar un estado de conductor válido.");

            RuleFor(x => x.Id)
                .GreaterThanOrEqualTo(0)
                .WithMessage("El ID del conductor no puede ser negativo.");
        }
    }
}