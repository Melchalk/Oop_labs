using oop9.Notifications;

namespace oop9;

internal class NotificationContainer<T> where T : Notification, IComparable
{
    public List<T> Notifications = new();

    public void Add(T notification)
    {
        Notifications.Add(notification);
    }

    public bool Remove(T notification)
    {
        return Notifications.Remove(notification);
    }

    public List<T> GetNotifications()
    {
        return Notifications;
    }

    public bool Contains(T notification)
    {
        return Notifications.Contains(notification);
    }

    public void Sort()
    {
        Notifications.Sort();
    }
}