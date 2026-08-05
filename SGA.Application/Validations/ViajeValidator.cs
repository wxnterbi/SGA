using FluentValidation;
using SGA.Application.Dtos.Viaje;

namespace SGA.Application.Validations
{
    public class ViajeValidator : AbstractValidator<ViajeDto>
    {
        public ViajeValidator()
        {
            RuleFor(x => x.RutaId)
                .GreaterThan(0)
                .WithMessage("Debe seleccionar una ruta válida.");

            RuleFor(x => x.HorarioId)
                .GreaterThan(0)
                .WithMessage("Debe seleccionar un horario válido.");

            RuleFor(x => x.AutobusId)
                .GreaterThan(0)
                .WithMessage("Debe seleccionar un autobús válido.");

            RuleFor(x => x.ConductorId)
                .GreaterThan(0)
                .WithMessage("Debe seleccionar un conductor válido.");
        }
    }
}