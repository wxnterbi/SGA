namespace SGA.Application.BusinessRules
{
    public class AccesoRules
    {
        public void ValidarCapacidadAutobus(int pasajerosActuales, int capacidadMaxima)
        {
            if (pasajerosActuales >= capacidadMaxima)
            {
                throw new Exception("Capacidad máxima del autobús alcanzada.");
            }
        }
    }
}