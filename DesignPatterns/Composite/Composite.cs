using Composite.Interfaces;

namespace Composite;

public class Composite : IGraphic
{
    private readonly List<IGraphic> _children = new();
    private readonly string _name;

    public Composite(string name)
    {
        _name = name;
    }

    public void Draw()
    {
        Console.WriteLine($"Desenează compozit: {_name}");
        foreach (var child in _children) child.Draw();
    }

    public void Add(IGraphic graphic)
    {
        _children.Add(graphic);
    }

    public void Remove(IGraphic graphic)
    {
        _children.Remove(graphic);
    }
}