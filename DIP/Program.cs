// See https://aka.ms/new-console-template for more information
using DIP.Services;

IMailingService mailingService = new SendGridMailingService();
var orderService = new OrderService(mailingService);

var o = new Order{
    Id = 1,
    Amount = 1000,
    ClientEmail = "fakeclient@orders.com"
};

orderService.Create(o);