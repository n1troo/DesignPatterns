namespace DesignPatterns.Liskov;

public class MountainDuck : Duck
{
    public override void Swim()
    {
        Console.WriteLine("Mountain swim");
    }

    public override void Quack()
    {
        Console.WriteLine("Mountain Quak");
    }

    
}