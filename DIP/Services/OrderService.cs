namespace DIP.Services;

public class OrderService
{
    private readonly IMailingService _mailingService;

    public OrderService(IMailingService mailingService)
    {
        _mailingService = mailingService;
    }

    public void Create(Order order)
    {
        System.Console.WriteLine($"Creada la orden con id{order.Id}");
        _mailingService.Send();
    }
}