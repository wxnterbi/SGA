public class AutorizacionRules
{
    public void ValidarAutorizacion(
        bool tieneTicketMensualValido,
        bool tieneTarjetaRecargableValida)
    {
        if (!tieneTicketMensualValido &&
            !tieneTarjetaRecargableValida)
        {
            throw new InvalidOperationException(
                "El usuario no posee una autorización válida para utilizar el servicio de transporte.");
        }
    }
}