namespace SGA.Infrastructure.Logging
{
    public class ErrorLogger
    {
        private readonly string _logPath = "error_log.txt";

        public void LogError(Exception ex)
        {
            try
            {
                string mensaje = $"[{DateTime.Now}] ERROR: {ex.Message} | StackTrace: {ex.StackTrace}{Environment.NewLine}";
                File.AppendAllText(_logPath, mensaje);
            }
            catch
            {
                throw new Exception("Fallo crítico en el sistema de Logging de infraestructura.");
            }
        }
    }
}