using AbstractFactory.Interfaces;

namespace AbstractFactory.Windows;

public class WindowsButton : IButton
{
    public void Render() => Console.WriteLine("Randează buton Windows");
}
