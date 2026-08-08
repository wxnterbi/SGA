namespace SGA.Application.BusinessRules
{
    public class IncidenciaRules
    {
        public void ValidarRegistroIncidencia(
            int viajeId,
            int conductorId)
        {
            if (viajeId <= 0)
                throw new InvalidOperationException(
                    "La incidencia debe estar asociada a un viaje.");

            if (conductorId <= 0)
                throw new InvalidOperationException(
                    "La incidencia debe estar asociada a un conductor.");
        }
    }
}
