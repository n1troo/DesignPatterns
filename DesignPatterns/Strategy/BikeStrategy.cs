namespace DesignPatterns.Strategy;

public class BikeStrategy : IRouteStrategy
{
    public void CreateRoute(Cordinate start, Cordinate End)
    {
        Console.WriteLine("bike strategy");
    }
}