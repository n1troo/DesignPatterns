namespace DesignPatterns.ChainOfResponsibility;

public abstract class BaseHandler : IHandler
{
    protected IHandler _next;
    
    public abstract void Handle(RequestContext requestContext);

    protected BaseHandler(IHandler next)
    {
        this._next = next;
    }
}