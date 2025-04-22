using AbstractFactory.Interfaces;

namespace AbstractFactory.Mac;

public class MacButton : IButton
{
    public void Render() => Console.WriteLine("Randează buton Mac");
}
