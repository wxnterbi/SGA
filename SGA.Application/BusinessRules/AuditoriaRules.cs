namespace SGA.Application.BusinessRules
{
    public class AuditoriaRules
    {
        public void ValidarRegistroAuditoria(bool registrada)
        {
            if (!registrada)
                throw new InvalidOperationException(
                    "La operación importante debe registrarse en la auditoría del sistema.");
        }
    }
}
