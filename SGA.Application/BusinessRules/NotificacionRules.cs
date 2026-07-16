namespace SGA.Application.BusinessRules
{
    public class NotificacionRules
    {
        public void ValidarEnvioNotificacion(bool enviada)
        {
            if (!enviada)
                throw new InvalidOperationException(
                    "La notificación del evento relevante no pudo ser enviada al usuario.");
        }
    }
}
