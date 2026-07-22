using FluentValidation;
using SGA.Application.Dtos.Ruta;

namespace SGA.Application.Validations
{
    public class RutaValidator : AbstractValidator<RutaDto>
    {
        public RutaValidator()
        {
            RuleFor(x => x.Nombre)
                .NotEmpty()
                .WithMessage("El nombre de la ruta es obligatorio.")
                .MaximumLength(60)
                .WithMessage("El nombre de la ruta no puede exceder los 60 caracteres.")
                .Must(nombre => !string.IsNullOrWhiteSpace(nombre))
                .WithMessage("El nombre de la ruta no puede estar vacío.");


            RuleFor(x => x.Origen)
                .NotEmpty()
                .WithMessage("El origen de la ruta es obligatorio.")
                .MaximumLength(100)
                .WithMessage("El origen no puede exceder los 100 caracteres.")
                .Must(origen => !string.IsNullOrWhiteSpace(origen))
                .WithMessage("El origen no puede estar vacío.");


            RuleFor(x => x.Destino)
                .NotEmpty()
                .WithMessage("El destino de la ruta es obligatorio.")
                .MaximumLength(100)
                .WithMessage("El destino no puede exceder los 100 caracteres.")
                .Must(destino => !string.IsNullOrWhiteSpace(destino))
                .WithMessage("El destino no puede estar vacío.");


            RuleFor(x => x.Id)
                .GreaterThanOrEqualTo(0)
                .WithMessage("El ID de la ruta no puede ser negativo.");
        }
    }
}