namespace DesignPatterns.Adapter;

public interface INotificationSender
{
    void SendNotification(int userId, Notyfication notyfication);
}