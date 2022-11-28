using DesignPatterns.DependencyInversion;

namespace DesignPatterns.Adapter;

public class EmailSender : INotificationSender
{
    public void SendNotification(int userId, Notyfication notyfication)
    {
        Console.WriteLine($"Sending e-mail: to {userId} title = {notyfication.Title} message = {notyfication.Body} "); 
    }
}