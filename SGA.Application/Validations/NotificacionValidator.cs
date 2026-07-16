using FluentValidation;
using SGA.Application.Dtos.Notificacion;

namespace SGA.Application.Validations
{
    public class NotificacionValidator : AbstractValidator<NotificacionDto>
    {
        public NotificacionValidator()
        {
            RuleFor(x => x.UsuarioId)
                .GreaterThan(0)
                .WithMessage("Debe seleccionar un usuario válido.");

            RuleFor(x => x.TipoEvento)
                .GreaterThan(0)
                .WithMessage("Debe seleccionar un tipo de evento válido.");

            RuleFor(x => x.Mensaje)
                .NotEmpty()
                .WithMessage("El mensaje es obligatorio.")
                .MaximumLength(250)
                .WithMessage("El mensaje no puede exceder los 250 caracteres.");

            RuleFor(x => x.FechaHora)
                .LessThanOrEqualTo(DateTime.Now)
                .WithMessage("La fecha de la notificación no puede ser futura.");
        }
    }
}
