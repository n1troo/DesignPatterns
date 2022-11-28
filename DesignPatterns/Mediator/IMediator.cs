namespace DesignPatterns.Mediator;

public interface IMediator
{
    void Notify(Component Sender, string @event);
}