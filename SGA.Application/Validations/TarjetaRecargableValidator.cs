using FluentValidation;
using SGA.Application.Dtos.TarjetaRecargable;

namespace SGA.Application.Validations
{
    public class TarjetaRecargableValidator : AbstractValidator<TarjetaRecargableDto>
    {
        public TarjetaRecargableValidator()
        {
            RuleFor(x => x.UsuarioId)
                .GreaterThan(0)
                .WithMessage("Debe seleccionar un usuario válido.");

            RuleFor(x => x.Saldo)
                .GreaterThanOrEqualTo(0)
                .WithMessage("El saldo no puede ser negativo.");
        }
    }
}
