namespace DesignPatterns.Strategy;

public class Map
{
    private readonly IRouteStrategy _routeStrategy;

    public Map(IRouteStrategy routeStrategy)
    {
        _routeStrategy = routeStrategy;
    }

    public void CreateRout(Cordinate start, Cordinate end )
    {
        _routeStrategy.CreateRoute(start, end);
    }
}