using Composite.Interfaces;

namespace Composite;

public class Client
{
    public void RenderGraphic(IGraphic graphic)
    {
        graphic.Draw();
    }
}