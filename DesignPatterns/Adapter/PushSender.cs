namespace DesignPatterns.Adapter;

public class PushSender : INotificationSender
{
    public void SendNotification(int userId, Notyfication notyfication)
    {
        Console.WriteLine($"Sending push to {userId} title = {notyfication.Title} message = {notyfication.Body}");
    }
}