using FluentValidation;
using SGA.Application.Dtos.RegistroAcceso;

namespace SGA.Application.Validations
{
    public class RegistroAccesoValidator : AbstractValidator<RegistroAccesoDto>
    {
        public RegistroAccesoValidator()
        {
            RuleFor(x => x.UsuarioId)
                .GreaterThan(0)
                .WithMessage("Debe seleccionar un usuario válido.");

            RuleFor(x => x.ViajeId)
                .GreaterThan(0)
                .WithMessage("Debe seleccionar un viaje válido.");

            RuleFor(x => x.Motivo)
                .NotEmpty()
                .WithMessage("Debe indicar el motivo del acceso.")
                .MaximumLength(250)
                .WithMessage("El motivo no puede exceder los 250 caracteres.");

            RuleFor(x => x.FechaHora)
                .LessThanOrEqualTo(DateTime.Now)
                .WithMessage("La fecha del registro no puede ser futura.");
        }
    }
}
