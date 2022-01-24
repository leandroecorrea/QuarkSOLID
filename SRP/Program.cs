// See https://aka.ms/new-console-template for more information
using System.Net.Mail;
using Moq;

//se crea un Mock del cliente SMTP para que devuelva la task completa
var smtpClientStub = new Mock<ISmtpClient>();
smtpClientStub.Setup(c => c.SendMailAsync(It.IsAny<MailMessage>())).Returns(Task.CompletedTask);
NotificationService notificationService = new NotificationService(smtpClientStub.Object);
OrderService orderService = new OrderService(notificationService);

Order o = new Order{
    Id = 1,
    Amount = 1999.99f,
    ClientEmail = "cliente@falso.com"
};

await orderService.Add(o);


