using System.Net.Mail;

public class NotificationService
{
    private readonly ISmtpClient _smtpClient;

    public NotificationService(ISmtpClient smtpClient)
    {
        _smtpClient = smtpClient;
    }

    public async Task SendEmail(MailMessage message)
    {
        await _smtpClient.SendMailAsync(message);
    }    
}