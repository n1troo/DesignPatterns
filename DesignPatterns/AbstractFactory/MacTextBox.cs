namespace DesignPatterns.AbstractFactory;

public class MacTextBox : ITextbox
{
    public void Render()
    {
        Console.WriteLine("Mac Render tex");
    }

    public void HandleInput()
    {
        Console.WriteLine("Mac handle tex input");
    }
}