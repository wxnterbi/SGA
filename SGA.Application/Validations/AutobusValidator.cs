using FluentValidation;
using SGA.Application.Dtos.Autobus;
using SGA.Application.Interfaces;
using SGA.Persistence.Interfaces;
using System.Text.RegularExpressions;

namespace SGA.Application.Validations
{
    public class AutobusValidator : AbstractValidator<AutobusDto>
    {
        private readonly IAutobusRepository _autobusRepository;

        public AutobusValidator(IAutobusRepository autobusRepository)
        {
            _autobusRepository = autobusRepository;

            RuleFor(x => x.Placa)
                .NotEmpty().WithMessage("La placa es obligatoria.")
                .Matches(@"^[A-Za-z]\d{5,6}$")
                .WithMessage("La placa debe contener exactamente 1 letra seguida de 5 a 6 números (Ejemplo: A12345 o A123456).")
                .MustAsync(async (dto, placa, cancellation) =>
                    !await _autobusRepository.ExistePlacaAsync(placa, dto.Id))
                .WithMessage("La placa ingresada ya se encuentra registrada en otro autobús.");

            RuleFor(x => x.Marca)
                .NotEmpty().WithMessage("La marca es obligatoria.")
                .MaximumLength(50).WithMessage("La marca no puede exceder los 50 caracteres.");

            RuleFor(x => x.Modelo)
                .NotEmpty().WithMessage("El modelo es obligatorio.")
                .MaximumLength(50).WithMessage("El modelo no puede exceder los 50 caracteres.");

            RuleFor(x => x.Capacidad)
                .InclusiveBetween(1, 100).WithMessage("La capacidad debe ser de entre 1 y 100 pasajeros.");

            RuleFor(x => x.EstadoAutobusId)
                .GreaterThan(0).WithMessage("Debe seleccionar un estado de autobús válido.");

            RuleFor(x => x.Id)
                .GreaterThanOrEqualTo(0).WithMessage("El ID del autobús no puede ser negativo.");
        }
    }
}