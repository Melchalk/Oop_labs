namespace oop9.Notifications;

internal class Notification : IComparable
{
    public string Content { get; set; }
    public string? SenderNickname { get; set; }

    public Notification(string senderNickname, string content)
    {
        Content = content;
        SenderNickname = senderNickname;
    }

    public Notification(string content)
    {
        Content = content;
    }

    public Notification() { }

    public int CompareTo(object? obj)
    {
        if (obj is Notification anotherNotification)
        {
            return Content.CompareTo(anotherNotification.Content);
        }
        else
        {
            throw new Exception("Conversion error");
        }
    }

    public virtual string GetInfo()
    {
        return $"{SenderNickname} - {Content}";
    }
}