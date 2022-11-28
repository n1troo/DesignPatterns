namespace DesignPatterns.Mediator;

public class RegisterClientView : IMediator
{
    private CheckBox _checkBox;
    private Button _button;

    public RegisterClientView(CheckBox checkBox, Button button)
    {
        _button = button;
        _checkBox = checkBox;
        
        _button.SetMediator(this);
        _checkBox.SetMediator(this);
    }
    public void Notify(Component Sender, string @event)
    {
        if (@event == "checkbox")
        {
            _button.Render();
        }
        else if(@event == "click")
        {
             _checkBox.SaveValue();;
        }
    }
}