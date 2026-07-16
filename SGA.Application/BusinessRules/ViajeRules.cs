namespace SGA.Application.BusinessRules
{
    public class ViajeRules
    {
        public void ValidarAsignacionViaje(
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
        }
    }
}