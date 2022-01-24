public class SmsNotificationService :INotification
{
    private readonly string _phoneNumber;
    private readonly string _subject;
    public SmsNotificationService(string phoneNumber, string subject)
    {
        _phoneNumber = phoneNumber;
        _subject = subject;
    }

    public async Task Notify()
    {
        System.Console.WriteLine($"Enviada notificación sms: phoneNumber {_phoneNumber} subject {_subject}");
    }
}