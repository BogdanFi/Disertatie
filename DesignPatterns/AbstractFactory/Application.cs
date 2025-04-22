using AbstractFactory.Interfaces;

namespace AbstractFactory;

public class Application
{
    private readonly IUIFactory _factory;
    public Application(IUIFactory factory) => _factory = factory;
    public void RenderUI()
    {
        var button = _factory.CreateButton();
        var textBox = _factory.CreateTextBox();
        button.Render();
        textBox.Display();
    }
}