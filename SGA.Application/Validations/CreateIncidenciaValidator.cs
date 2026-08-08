using FluentValidation;
using SGA.Application.Dtos.Incidencia;

namespace SGA.Application.Validations
{
    public class CreateIncidenciaValidator
        : AbstractValidator<CreateIncidenciaDto>
    {
        public CreateIncidenciaValidator()
        {
            RuleFor(x => x.ViajeId)
                .GreaterThan(0)
                .WithMessage("Debe seleccionar un viaje válido.");

            RuleFor(x => x.ConductorId)
                .GreaterThan(0)
                .WithMessage("Debe seleccionar un conductor válido.");

            RuleFor(x => x.Tipo)
                .GreaterThan(0)
                .WithMessage("Debe seleccionar un tipo de incidencia válido.");

            RuleFor(x => x.Descripcion)
                .NotEmpty()
                .WithMessage("La descripción es obligatoria.")
                .MaximumLength(500)
                .WithMessage("La descripción no puede exceder los 500 caracteres.");

            RuleFor(x => x.FechaHora)
                .NotEmpty()
                .WithMessage("La fecha y hora de la incidencia son obligatorias.");
        }
    }
}
