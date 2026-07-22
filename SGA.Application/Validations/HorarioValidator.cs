using FluentValidation;
using SGA.Application.Dtos.Horario;

namespace SGA.Application.Validations
{
    public class HorarioValidator : AbstractValidator<HorarioDto>
    {
        public HorarioValidator()
        {
            RuleFor(x => x.DiasOperacion)
                .NotEmpty()
                .WithMessage("Los días de operación son obligatorios.")
                .MaximumLength(100)
                .WithMessage("Los días de operación no pueden exceder los 100 caracteres.")
                .Must(dias => !string.IsNullOrWhiteSpace(dias))
                .WithMessage("Los días de operación no pueden estar vacíos.");


            RuleFor(x => x.HoraSalida)
                .NotEqual(TimeSpan.Zero)
                .WithMessage("Debe indicar una hora de salida válida.");


            RuleFor(x => x.RutaId)
                .GreaterThan(0)
                .WithMessage("Debe seleccionar una ruta válida.");


            RuleFor(x => x.Id)
                .GreaterThanOrEqualTo(0)
                .WithMessage("El ID del horario no puede ser negativo.");
        }
    }
}