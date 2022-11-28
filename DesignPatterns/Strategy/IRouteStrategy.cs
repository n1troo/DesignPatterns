namespace DesignPatterns.Strategy;

public interface IRouteStrategy
{
    void CreateRoute(Cordinate start, Cordinate End);
}