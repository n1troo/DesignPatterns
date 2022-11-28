namespace DesignPatterns.ChainOfResponsibility;

public interface IHandler
{
    void  Handle(RequestContext requestContext);
}