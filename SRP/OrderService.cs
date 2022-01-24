using System.Net.Mail;

public class OrderService
{
    private readonly NotificationService _notificationService;

    public OrderService(NotificationService notificationService)
    {
        _notificationService = notificationService;
    }

    public async Task Add(Order order)
    {
        Console.WriteLine($"Fue creada la orden con ID {order.Id} con el monto total de ${order.Amount}");
        var message = new MailMessage ("sales@admin.com", order.ClientEmail)
        {
            Subject = "Se le asignó una compra",
            Body = "Estimado,\n Hemos creado su nueva orden de compra .."
        };
        await _notificationService.SendEmail(message);
    }
}