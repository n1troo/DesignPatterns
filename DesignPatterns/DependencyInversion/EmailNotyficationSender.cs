namespace DesignPatterns.DependencyInversion;

public class EmailNotyficationSender : INotyficationService
{
    public void SendNotyfication(User user)
    {
        Console.WriteLine($"Send email to user {user.Login}");
    }
}