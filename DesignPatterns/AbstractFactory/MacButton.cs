namespace DesignPatterns.AbstractFactory;

public class MacButton : IButton
{
    public void Render()
    {
        Console.WriteLine("Mac Render");
    }

    public void HandleClick()
    {
        Console.WriteLine("Mac cliked");
    }
}