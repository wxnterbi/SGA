using FluentValidation;
using SGA.Application.Dtos.Pago;

namespace SGA.Application.Validations
{
    public class PagoValidator : AbstractValidator<PagoDto>
    {
        public PagoValidator()
        {
            RuleFor(x => x.UsuarioId)
                .GreaterThan(0)
                .WithMessage("Debe seleccionar un usuario válido.");

            RuleFor(x => x.Monto)
                .GreaterThan(0)
                .WithMessage("El monto debe ser mayor que cero.");

            RuleFor(x => x.FechaPago)
                .LessThanOrEqualTo(DateTime.Now)
                .WithMessage("La fecha del pago no puede ser futura.");

            RuleFor(x => x.Modalidad)
                .NotEmpty()
                .WithMessage("La modalidad es obligatoria.")
                .MaximumLength(50)
                .WithMessage("La modalidad no puede exceder los 50 caracteres.");
        }
    }
}