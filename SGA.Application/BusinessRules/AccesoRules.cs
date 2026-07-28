namespace SGA.Application.BusinessRules
{
    public class AccesoRules
    {
        public string? ValidarAutorizacion(bool autorizacionValida)
        {
            if (!autorizacionValida)
            {
                return "El usuario no posee una autorización válida para utilizar el servicio.";
            }

            return null;
        }
    }
}