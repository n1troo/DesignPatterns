namespace DesignPatterns.Liskov;

public class CityDuck : Duck
{
    public override void Swim()
    {
        Console.WriteLine("City swim");
    }

    public override void Quack()
    {
        Console.WriteLine("City quak");
    }

    
}