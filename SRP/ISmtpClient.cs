using System.Net.Mail;

public interface ISmtpClient
{
    Task SendMailAsync(MailMessage message);
}