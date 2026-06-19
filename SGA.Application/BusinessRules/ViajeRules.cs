namespace SGA.Application.BusinessRules
{
    public class ViajeRules
    {
        public void ValidarCierreViaje(string estadoActual)
        {
            if (estadoActual != "Iniciado")
            {
                throw new Exception("No permitir cerrar un viaje que no inició.");
            }
        }
    }
}