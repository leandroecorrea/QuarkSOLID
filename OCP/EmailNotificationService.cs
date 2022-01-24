public class EmailNotificationService :INotification
{
    private readonly string _to;
    private readonly string _subject;
    public EmailNotificationService(string to, string subject)
    {
        _to = to;
        _subject = subject;
    }

    public async Task Notify()
    {
        System.Console.WriteLine($"Enviada notificación por email: to {_to} subject {_subject}");
    }
}