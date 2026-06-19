namespace SGA.Infrastructure.Notifications
{
    public class EmailNotificationService : INotificationService
    {
        public async Task SendNotificationAsync(string destinatario, string asunto, string mensaje)
        {
            try
            {
                await Task.Delay(100);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al procesar el envío de notificación por correo electrónico: {ex.Message}");
            }
        }
    }
}