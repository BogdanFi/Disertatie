using Composite.Interfaces;

namespace Composite;

public class Leaf : IGraphic
{
    private readonly string _name;

    public Leaf(string name)
    {
        _name = name;
    }

    public void Draw()
    {
        Console.WriteLine($"Desenează frunză: {_name}");
    }
}