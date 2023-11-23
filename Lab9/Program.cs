using oop9;
using oop9.Notifications;

NotificationContainer<EmailNotification> emails = new();
NotificationContainer<PushNotification> pushes = new();
NotificationContainer<SMSNotification> smses = new();

emails.Add(new EmailNotification("melm", "superdog@mail.ru", "HI!"));
emails.Add(new EmailNotification("mel", "melm2004@mail.ru", "Hello"));

pushes.Add(new PushNotification("Telegram", "Melchalk", "Hi"));
pushes.Add(new PushNotification("VK", "Mel", "Hello"));

smses.Add(new SMSNotification("555-3535", "Hello"));

//выдаст ошибку
/*var sms = new SMSNotification("555-3535", "ewyjkjhgfewel;lkjhgfdsdfghjkl;lkjuyhtrertyujikolp;lkjhgf" +
    "dswedrftyhujikolp;;plokiujyhtrewedfrghjukilo;lkjhgtr");*/

var sms = new SMSNotification("900", "New card!");

if (smses.Contains(sms))
{
    Console.WriteLine("Смс уже добавлено");
}
else
{
    smses.Add(sms);
}

//отсортируется по контенту
emails.Sort();
pushes.Sort();
smses.Sort();

Console.WriteLine("--- Emails ---");
foreach (var notification in emails.GetNotifications())
{
    Console.WriteLine(notification.GetInfo());
}

Console.WriteLine("\n--- Pushes ---");
foreach (var notification in pushes.GetNotifications())
{
    Console.WriteLine(notification.GetInfo());
}

Console.WriteLine("\n--- Smses ---");
foreach (var notification in smses.GetNotifications())
{
    Console.WriteLine(notification.GetInfo());
}