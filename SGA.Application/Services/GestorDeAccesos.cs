using SGA.Application.BusinessRules;
using SGA.Infrastructure.Logging;

namespace SGA.Application.Services
{
    public class GestorDeAccesos
    {
        private readonly AccesoRules _rules;
        private readonly ErrorLogger _logger;

        public GestorDeAccesos(AccesoRules rules, ErrorLogger logger)
        {
            _rules = rules;
            _logger = logger;
        }

        public void ProcesarIngresoAutobus(int pasajerosActuales, int capacidadMaxima)
        {
            try
            {
                _rules.ValidarCapacidadAutobus(pasajerosActuales, capacidadMaxima);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex);
                throw new Exception("Operación denegada en el Control de Acceso: " + ex.Message);
            }
        }
    }
}