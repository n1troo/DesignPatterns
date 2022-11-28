namespace DesignPatterns.ChainOfResponsibility;

public class RequestContext
{
    public Request Request { get; set; }
    public Response Response { get; set; }
}