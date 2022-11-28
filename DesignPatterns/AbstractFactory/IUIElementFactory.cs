namespace DesignPatterns.AbstractFactory;

public interface IUIElementFactory
{
    IButton CreateButton();
    ITextbox CreateTextbox();
}