namespace DesignPatterns.AbstractFactory;

public class Application
{
    private IUIElementFactory _uiElementFactory;

    public Application(IUIElementFactory uiElementFactory)
    {
        _uiElementFactory = uiElementFactory;
    }

    public void RenderUI()
    {
        var button = _uiElementFactory.CreateButton();
        var textbox = _uiElementFactory.CreateTextbox();
        
        button.Render();
        textbox.Render();

    }
}