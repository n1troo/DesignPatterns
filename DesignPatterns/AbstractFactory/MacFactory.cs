namespace DesignPatterns.AbstractFactory;

public class MacFactory : IUIElementFactory
{
    public IButton CreateButton()
    {
        return new MacButton();
    }

    public ITextbox CreateTextbox()
    {
        return new MacTextBox();
    }
}