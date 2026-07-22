using FluentValidation;
using SGA.Application.Dtos.Parada;

namespace SGA.Application.Validations
{
    public class ParadaValidator : AbstractValidator<ParadaDto>
    {
        public ParadaValidator()
        {
            RuleFor(x => x.Nombre)
                .NotEmpty()
                .WithMessage("El nombre de la parada es obligatorio.")
                .MaximumLength(60)
                .WithMessage("El nombre de la parada no puede exceder los 60 caracteres.")
                .Must(nombre => !string.IsNullOrWhiteSpace(nombre))
                .WithMessage("El nombre de la parada no puede estar vacío.");


            RuleFor(x => x.Ubicacion)
                .NotEmpty()
                .WithMessage("La ubicación de la parada es obligatoria.")
                .MaximumLength(100)
                .WithMessage("La ubicación no puede exceder los 100 caracteres.")
                .Must(ubicacion => !string.IsNullOrWhiteSpace(ubicacion))
                .WithMessage("La ubicación no puede estar vacía.");


            RuleFor(x => x.Orden)
                .GreaterThan(0)
                .WithMessage("El orden de la parada debe ser mayor que cero.");


            RuleFor(x => x.Id)
                .GreaterThanOrEqualTo(0)
                .WithMessage("El ID de la parada no puede ser negativo.");
        }
    }
}