namespace SGA.Application.BusinessRules
{
    public class IncidenciaRules
    {
        public void ValidarRegistroIncidencia(bool registrada)
        {
            if (!registrada)
                throw new InvalidOperationException(
                    "La incidencia debe quedar registrada para fines de seguimiento y control.");
        }
    }
}
