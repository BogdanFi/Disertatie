using AbstractFactory.Interfaces;

namespace AbstractFactory.Windows;

public class WindowsTextBox : ITextBox
{
    public void Display() => Console.WriteLine("Afișează textbox Windows");
}