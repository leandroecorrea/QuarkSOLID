namespace DIP.Services;
public class SendGridMailingService : IMailingService
{
    public void Send()
    {
        System.Console.WriteLine($"Mail sent using {this.ToString()}");
    }
}