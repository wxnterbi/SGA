using FluentValidation;
using SGA.Application.Dtos.Autobus;

namespace SGA.Application.Validations
{
    public class AutobusValidator : AbstractValidator<AutobusDto>
    {
        public AutobusValidator()
        {

            RuleFor(x => x.Placa)
                .NotEmpty()
                .WithMessage("La placa es obligatoria.")
                .Matches(@"^[A-Za-z]\d{5,6}$")
                .WithMessage("La placa debe contener exactamente 1 letra seguida de 5 a 6 números (Ejemplo: A12345 o A123456).");


            RuleFor(x => x.Marca)
                .NotEmpty()
                .WithMessage("La marca es obligatoria.")
                .MaximumLength(50)
                .WithMessage("La marca no puede exceder los 50 caracteres.");


            RuleFor(x => x.Modelo)
                .NotEmpty()
                .WithMessage("El modelo es obligatorio.")
                .MaximumLength(50)
                .WithMessage("El modelo no puede exceder los 50 caracteres.");


            RuleFor(x => x.Capacidad)
                .InclusiveBetween(1, 100)
                .WithMessage("La capacidad debe ser de entre 1 y 100 pasajeros.");


            RuleFor(x => x.EstadoAutobusId)
                .GreaterThan(0)
                .WithMessage("Debe seleccionar un estado de autobús válido.");


            RuleFor(x => x.Id)
                .GreaterThanOrEqualTo(0)
                .WithMessage("El ID del autobús no puede ser negativo.");

        }
    }
}