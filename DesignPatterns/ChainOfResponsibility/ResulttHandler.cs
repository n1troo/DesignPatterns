﻿namespace DesignPatterns.ChainOfResponsibility;

public class ResultHandler: BaseHandler
{
    public ResultHandler(IHandler next) : base(next)
    {
    }

    public override void Handle(RequestContext requestContext)
    {
        requestContext.Response.IsSuccessful = true;
        requestContext.Response.Data = "SOME VALUE";
    }
}