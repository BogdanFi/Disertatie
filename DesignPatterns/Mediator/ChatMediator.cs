using Mediator.Interfaces;

namespace Mediator;

public class ChatMediator : IMediator
{
    private readonly List<IColleague> _colleagues = new();

    public void Notify(object sender, string ev)
    {
        foreach (var colleague in _colleagues)
        {
            if (colleague != sender)
            {
                colleague.Receive(ev);
            }
        }
    }

    public void Register(IColleague colleague)
    {
        _colleagues.Add(colleague);
    }
}