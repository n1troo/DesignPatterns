namespace DesignPatterns.Prototype;

public class Circle : Shape
{
    public  int Radius { get; set; }
    public override void Render()
    {
        Console.WriteLine("Render Circle");
    }

    public override Shape Clone()
    {
        Circle cloneBase = (Circle)this.MemberwiseClone();
        cloneBase.Border = new Border()
        {
            Color = cloneBase.Border.Color,
            Size = cloneBase.Border.Size
        };
        return cloneBase;
    }
}