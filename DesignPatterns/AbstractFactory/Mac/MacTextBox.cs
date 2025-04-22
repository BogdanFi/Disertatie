using AbstractFactory.Interfaces;

namespace AbstractFactory.Mac;

public class MacTextBox : ITextBox
{
    public void Display() => Console.WriteLine("Afișează textbox Mac");
}
