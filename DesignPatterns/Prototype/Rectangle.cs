namespace DesignPatterns.Prototype;

public class Rectangle : Shape
{
    public override void Render()
    {
        Console.WriteLine("Render Rectangle");
    }

    public override Shape Clone()
    {
        var cloneBase = (Rectangle) this.MemberwiseClone();

        Border border = new Border()
        {
            Color = cloneBase.Border.Color,
            Size = cloneBase.Border.Size
        };

        cloneBase.Border = border;

        return cloneBase;
    }
}