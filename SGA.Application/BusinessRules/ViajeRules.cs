using SGA.Persistence.Interfaces;

namespace SGA.Application.BusinessRules
{
    public class ViajeRules
    {
        private readonly IViajeRepository _viajeRepository;

        public ViajeRules(IViajeRepository viajeRepository)
        {
            _viajeRepository = viajeRepository;
        }

        public async Task ValidarAsignacionViaje(
            int rutaId,
            int horarioId,
            int autobusId,
            int conductorId)
        {
            if (rutaId <= 0)
                throw new InvalidOperationException(
                    "El viaje debe estar asociado a una ruta.");

            if (horarioId <= 0)
                throw new InvalidOperationException(
                    "El viaje debe estar asociado a un horario.");

            if (autobusId <= 0)
                throw new InvalidOperationException(
                    "El viaje debe estar asociado a un autobús.");

            if (conductorId <= 0)
                throw new InvalidOperationException(
                    "El viaje debe estar asociado a un conductor.");


            bool autobusOcupado =
                await _viajeRepository.ExisteAutobusEnHorarioAsync(
                    autobusId,
                    horarioId);


            if (autobusOcupado)
                throw new InvalidOperationException(
                    "El autobús seleccionado ya se encuentra asignado a otro viaje en esa misma hora.");


            bool conductorOcupado =
                await _viajeRepository.ExisteConductorEnHorarioAsync(
                    conductorId,
                    horarioId);


            if (conductorOcupado)
                throw new InvalidOperationException(
                    "El conductor seleccionado ya tiene un viaje programado o en curso en esa misma hora.");
        }
    }
}