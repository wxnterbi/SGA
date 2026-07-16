namespace SGA.Application.BusinessRules
{
    public class AccesoRules
    {
        public void ValidarAutorizacion(bool autorizacionValida)
        {
            if (!autorizacionValida)
                throw new InvalidOperationException(
                    "El usuario no posee una autorización válida para utilizar el servicio.");
        }
    }
}