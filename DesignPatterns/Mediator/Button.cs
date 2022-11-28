namespace DesignPatterns.Mediator;

public class Button : Component
{
    public void Render()
    {
        Console.WriteLine("Render button");
    }

    public void Click()
    {
        Console.WriteLine("Button was cliked");
        this._mediator.Notify(this,"click");
    }
}