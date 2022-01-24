namespace DIP.Services;
public class ChimpMailingService : IMailingService
{
    public void Send()
    {
        System.Console.WriteLine($"Mail sent using{this.ToString()}");
    }
}