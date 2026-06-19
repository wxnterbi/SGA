namespace SGA.Application.BusinessRules
{
    public class UsuarioRules
    {
        public void ValidarAcceso(bool tieneAutorizacionActiva)
        {
            if (!tieneAutorizacionActiva)
            {
                throw new Exception("No permitir acceso sin autorización.");
            }
        }
    }
}