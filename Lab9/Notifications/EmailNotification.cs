namespace oop9.Notifications;

internal class EmailNotification : Notification
{
    public string Mail { get; set; }
    public string MailDomain { get; set; }

    public EmailNotification(string senderNickname, string mail, string content) : base(senderNickname, content)
    {
        if (mail.Contains('@'))
        {
            Mail = mail;
            MailDomain = mail[(mail.IndexOf('@') + 1)..];
        }
        else
        {
            throw new Exception("Invalid email address");
        }
    }

    public override string GetInfo()
    {
        return $"{Mail}: {Content}";
    }
}