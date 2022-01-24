public class NotificationService
{
    public async Task Send(List<INotification> notifications)
    {
        notifications.ForEach(n => n.Notify());
    }
}