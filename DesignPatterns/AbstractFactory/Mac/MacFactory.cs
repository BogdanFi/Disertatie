using AbstractFactory.Interfaces;

namespace AbstractFactory.Mac;

public class MacFactory : IUIFactory
{
    public IButton CreateButton() => new MacButton();
    public ITextBox CreateTextBox() => new MacTextBox();
}