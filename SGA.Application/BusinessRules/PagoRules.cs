namespace SGA.Application.BusinessRules
{
    public class PagoRules
    {
        public void ValidarSaldo(decimal saldoActual, decimal montoConsumo)
        {
            if ((saldoActual - montoConsumo) < 0)
            {
                throw new Exception("No permitir saldo negativo.");
            }
        }

        public void ValidarEmisionTicket(bool pagoConfirmado)
        {
            if (!pagoConfirmado)
            {
                throw new Exception("No permitir emitir ticket sin pago.");
            }
        }
    }
}