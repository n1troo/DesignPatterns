namespace DesignPatterns.Decorator;

public class CheessePizzaDecorator : PizzaDecorator
{
    public CheessePizzaDecorator(IPizza pizza) : base(pizza)
    {
    }

    public override double CalculatePrice()
    {
        return base.CalculatePrice() + 5;
    }
}