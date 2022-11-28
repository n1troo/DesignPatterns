namespace DesignPatterns.Mediator;

public class CheckBox : Component
{
    public void Select()
    {
        Console.WriteLine("CheckBox was selected");
        _mediator.Notify(this, "checkbox");
    }

    public void SaveValue()
    {
        Console.WriteLine("CheckBox value saved");
    }
}