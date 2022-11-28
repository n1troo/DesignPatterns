namespace DesignPatterns.Prototype;

public class Triangle : Shape
{
    public override void Render()
    {
        Console.WriteLine("Render triangle");
    }

    public override Shape Clone()
    {
        return  (Triangle)this.MemberwiseClone();
    }
}