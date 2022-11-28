namespace DesignPatterns.AbstractFactory;

public class WindowsButton : IButton
{
    public void Render()
    {
        Console.WriteLine("Windows Render");
    }

    public void HandleClick()
    {
        Console.WriteLine("Windows Clicked");
    }
}