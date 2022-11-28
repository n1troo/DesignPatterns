namespace DesignPatterns.AbstractFactory;

public class WindowsTextBox : ITextbox
{
    public void Render()
    {
        Console.WriteLine("windows render textroxo");
    }

    public void HandleInput()
    {
        Console.WriteLine("windows handler input");
    }
}