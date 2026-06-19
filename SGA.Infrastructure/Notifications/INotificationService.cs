namespace SGA.Infrastructure.Notifications
{
    public interface INotificationService
    {
        Task SendNotificationAsync(string destinatario, string asunto, string mensaje);
    }
}