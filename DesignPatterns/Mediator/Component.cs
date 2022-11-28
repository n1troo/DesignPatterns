namespace DesignPatterns.Mediator;

public abstract class Component
{
    protected IMediator _mediator;

    public void SetMediator(IMediator mediator)
    {
        _mediator = mediator;
    }
    
}