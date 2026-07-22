namespace SGA.Infrastructure.Notifications
{
    public class EmailNotificationService : INotificationService
    {
        public async Task SendNotificationAsync(string destinatario, string asunto, string mensaje)
        {
            try
            {
                await Task.Delay(100);

                Console.WriteLine("========== NOTIFICACIÓN ==========");
                Console.WriteLine($"Destinatario: {destinatario}");
                Console.WriteLine($"Asunto: {asunto}");
                Console.WriteLine($"Mensaje: {mensaje}");
                Console.WriteLine("==================================");
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al procesar el envío de notificación: {ex.Message}");
            }
        }
    }
}