namespace oop9.Notifications;

internal class PushNotification : Notification
{
    public string Application { get; set; }

    public PushNotification(string application, string content) : base(content)
    {
        Application = application;
    }

    public PushNotification(string application, string senderNickname, string content) : base(senderNickname, content)
    {
        SenderNickname = senderNickname;
        Application = application;
    }

    public override string GetInfo()
    {
        return $"{Application}:\n{SenderNickname} - {Content}";
    }
}