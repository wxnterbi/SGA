using FluentValidation;
using SGA.Application.Dtos.Pago;
using SGA.Domain.Enums.Reservation;

namespace SGA.Application.Validations
{
    public class ComprarTicketValidator : AbstractValidator<ComprarTicketDto>
    {
        public ComprarTicketValidator()
        {

            RuleFor(x => x.UsuarioId)
                .GreaterThan(0)
                .WithMessage("Debe existir un usuario válido.");

            RuleFor(x => x.TipoTicket)
                .IsInEnum()
                .When(x => !x.EsMensual)
                .WithMessage("Debe seleccionar un tipo de ticket.");

            RuleFor(x => x.RutaEntradaId)
                .NotNull()
                .When(x => x.EsMensual ||
                           x.TipoTicket == TipoTicket.Entrada ||
                           x.TipoTicket == TipoTicket.EntradaYSalida)
                .WithMessage("Debe seleccionar una ruta de entrada.");

            RuleFor(x => x.HorarioEntradaId)
                .NotNull()
                .When(x => x.EsMensual ||
                           x.TipoTicket == TipoTicket.Entrada ||
                           x.TipoTicket == TipoTicket.EntradaYSalida)
                .WithMessage("Debe seleccionar un horario de entrada.");

            RuleFor(x => x.ParadaEntradaId)
                .NotNull()
                .When(x => x.EsMensual ||
                           x.TipoTicket == TipoTicket.Entrada ||
                           x.TipoTicket == TipoTicket.EntradaYSalida)
                .WithMessage("Debe seleccionar una parada de entrada.");

            RuleFor(x => x.RutaSalidaId)
                .NotNull()
                .When(x => x.EsMensual ||
                           x.TipoTicket == TipoTicket.Salida ||
                           x.TipoTicket == TipoTicket.EntradaYSalida)
                .WithMessage("Debe seleccionar una ruta de salida.");

            RuleFor(x => x.HorarioSalidaId)
                .NotNull()
                .When(x => x.EsMensual ||
                           x.TipoTicket == TipoTicket.Salida ||
                           x.TipoTicket == TipoTicket.EntradaYSalida)
                .WithMessage("Debe seleccionar un horario de salida.");

            RuleFor(x => x.ParadaSalidaId)
                .NotNull()
                .When(x => x.EsMensual ||
                           x.TipoTicket == TipoTicket.Salida ||
                           x.TipoTicket == TipoTicket.EntradaYSalida)
                .WithMessage("Debe seleccionar una parada de salida.");
        }
    }
}
