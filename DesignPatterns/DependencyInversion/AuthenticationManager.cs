namespace DesignPatterns.DependencyInversion;

public class AuthenticationManager
{
    private readonly INotyficationService _notyficationService;

    public AuthenticationManager(INotyficationService notyficationService)
    {
        _notyficationService = notyficationService;
    }
    
    public void AuthenticateUser(User user, string login, string password)
    {
        if (user.Login == login && user.Password == password)
        {
            _notyficationService.SendNotyfication(user);
        }
    }
}