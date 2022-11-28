namespace DesignPatterns.Adapter;

public class SmsSenderAdapter : INotificationSender
{
    private SmsSender _smsSender = new SmsSender();

    public void SendNotification(int userId, Notyfication notyfication)
    {
        string usernumber = null; //base on id user taking
        _smsSender.SendSMS(usernumber, $"{notyfication.Title} {notyfication.Body}");
    }
}