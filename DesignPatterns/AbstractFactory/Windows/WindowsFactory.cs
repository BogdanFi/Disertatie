using AbstractFactory.Interfaces;

namespace AbstractFactory.Windows;

public class WindowsFactory : IUIFactory
{
    public IButton CreateButton() => new WindowsButton();
    public ITextBox CreateTextBox() => new WindowsTextBox();
}