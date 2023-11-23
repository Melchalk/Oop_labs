namespace oop9.Notifications;

internal class SMSNotification : Notification
{
    private const int MAX_LENGHT = 100;
    public string Telephone { get; set; }

    public SMSNotification(string telephone, string content)
    {
        if (content.Length > MAX_LENGHT)
            throw new Exception("The message is too long");

        Content = content;
        Telephone = telephone;
    }

    public override string GetInfo()
    {
        return $"{Telephone} - {Content}";
    }
}