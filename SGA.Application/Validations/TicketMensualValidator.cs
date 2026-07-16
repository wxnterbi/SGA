using FluentValidation;
using SGA.Application.Dtos.TicketMensual;

namespace SGA.Application.Validations
{
    public class TicketMensualValidator : AbstractValidator<TicketMensualDto>
    {
        public TicketMensualValidator()
        {
            RuleFor(x => x.UsuarioId)
                .GreaterThan(0)
                .WithMessage("Debe seleccionar un usuario válido.");

            RuleFor(x => x.PagoId)
                .GreaterThan(0)
                .WithMessage("Debe seleccionar un pago válido.");

            RuleFor(x => x.FechaInicio)
                .LessThanOrEqualTo(x => x.FechaFin)
                .WithMessage("La fecha de inicio no puede ser mayor que la fecha de fin.");

            RuleFor(x => x.Estado)
                .GreaterThanOrEqualTo(0)
                .WithMessage("Debe indicar un estado válido.");
        }
    }
}
