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
                .MaximumLength(15)
                .WithMessage("La placa no puede exceder los 15 caracteres.")
                .Must(placa => !string.IsNullOrWhiteSpace(placa))
                .WithMessage("La placa no puede estar vacía.");

            RuleFor(x => x.Marca)
                .NotEmpty()
                .WithMessage("La marca es obligatoria.")
                .MaximumLength(50)
                .WithMessage("La marca no puede exceder los 50 caracteres.")
                .Must(marca => !string.IsNullOrWhiteSpace(marca))
                .WithMessage("La marca no puede estar vacía.");

            RuleFor(x => x.Modelo)
                .NotEmpty()
                .WithMessage("El modelo es obligatorio.")
                .MaximumLength(50)
                .WithMessage("El modelo no puede exceder los 50 caracteres.")
                .Must(modelo => !string.IsNullOrWhiteSpace(modelo))
                .WithMessage("El modelo no puede estar vacío.");

            RuleFor(x => x.Capacidad)
                .GreaterThan(0)
                .WithMessage("La capacidad debe ser mayor que cero.");

            RuleFor(x => x.EstadoAutobusId)
                .GreaterThan(0)
                .WithMessage("Debe seleccionar un estado de autobús válido.");

            RuleFor(x => x.Id)
                .GreaterThanOrEqualTo(0)
                .WithMessage("El ID del autobús no puede ser negativo.");
        }
    }
}