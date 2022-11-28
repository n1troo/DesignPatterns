namespace DesignPatterns.Strategy;

public class CarStrategy : IRouteStrategy
{
    public void CreateRoute(Cordinate start, Cordinate End)
    {
        Console.WriteLine("car strategy");
    }
}