namespace DesignPatterns.ChainOfResponsibility;

public class AuthoryzationHandler : BaseHandler
{
    private Dictionary<int, int> entityOwners = new Dictionary<int, int>()
    {
        { 101, 13 },
        { 102, 14 }
    };
    
    public AuthoryzationHandler(IHandler next) : base(next)
    {
    }

    public override void Handle(RequestContext requestContext)
    {
        if (requestContext.Request.UserRole == "Admin")
        {
            _next.Handle(requestContext);
            return;
        }

        if (entityOwners.TryGetValue(requestContext.Request.EntityID, out int ownerId))
        {
            if (ownerId == requestContext.Request.UserID)
            {
                _next.Handle(requestContext);
                return;
            }
        }

        requestContext.Response.IsSuccessful = false;
        requestContext.Response.Message = "User is not authorized";
    }
}