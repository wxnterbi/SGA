namespace SGA.Application.BusinessRules
{
    public class PagoRules
    {
        public void ValidarPago(bool pagoRealizado)
        {
            if (!pagoRealizado)
                throw new InvalidOperationException("Debe existir un pago válido para realizar esta operación.");
        }
    }
}