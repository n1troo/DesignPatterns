namespace DesignPatterns.ChainOfResponsibility;

public class ValidationHandler : BaseHandler
{
    public ValidationHandler(IHandler next) : base(next)
    {
    }

    public override void Handle(RequestContext requestContext)
    {
        if (requestContext.Request.EntityID > 100)
        {
            _next.Handle(requestContext);
            return;
        }

        requestContext.Response.IsSuccessful = false;
        requestContext.Response.Message = "Validation error: Entity must bye greater than 100";
    }
}