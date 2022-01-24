// See https://aka.ms/new-console-template for more information
var notification = new List<INotification>{
    new EmailNotificationService("usuario@falso.com", "receptor@falso.com"),
    new SmsNotificationService("0303456", "abonado telefónico")
};
var notificationService = new NotificationService();
await notificationService.Send(notification);
