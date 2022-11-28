namespace DesignPatterns.DependencyInversion;

public class SmsNotyficationSender : INotyficationService
{
    public void SendNotyfication(User user)
    {
        Console.WriteLine($"Notyfication send by SMS to {user.Login}");
    }
}