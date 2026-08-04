using FluentValidation;
using SGA.Application.Dtos.Viaje;
using SGA.Persistence.Repositories;

namespace SGA.Application.Validations
{
    public class ViajeValidator : AbstractValidator<ViajeDto>
    {
        public ViajeValidator()
        {
            _viajeRepository = viajeRepository;

            RuleFor(x => x.RutaId)
                .GreaterThan(0)
                .WithMessage("Debe seleccionar una ruta válida.");

            RuleFor(x => x.HorarioId)
                .GreaterThan(0)
                .WithMessage("Debe seleccionar un horario válido.");

            RuleFor(x => x.AutobusId)
                .GreaterThan(0)
                .WithMessage("Debe seleccionar un autobús válido.")
                .MustAsync(async (dto, autobusId, cancellation) =>
                    !await _viajeRepository.ExisteAutobusEnHorarioAsync(autobusId, dto.HorarioId))
                .WithMessage("El autobús seleccionado ya se encuentra asignado a otro viaje en esa misma hora.");

            RuleFor(x => x.ConductorId)
                .GreaterThan(0)
                .WithMessage("Debe seleccionar un conductor válido.")
                .MustAsync(async (dto, conductorId, cancellation) =>
                    !await _viajeRepository.ExisteConductorEnHorarioAsync(conductorId, dto.HorarioId))
                .WithMessage("El conductor seleccionado ya tiene un viaje programado o en curso en esa misma hora.");
        }
    }
}