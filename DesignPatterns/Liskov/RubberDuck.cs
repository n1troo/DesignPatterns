namespace DesignPatterns.Liskov;

public class RubberDuck : Duck
{
    public override void Swim()
    {
        Console.WriteLine("Rubber swim");
    }

    public override void Quack()
    {
        Console.WriteLine("Rubber quak");
    }
}