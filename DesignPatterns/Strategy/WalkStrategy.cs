namespace DesignPatterns.Strategy;

public class WalkStrategy : IRouteStrategy
{
    public void CreateRoute(Cordinate start, Cordinate End)
    {
        Console.WriteLine("walk strategy");
    }
}