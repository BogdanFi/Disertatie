using Mediator.Interfaces;

namespace Mediator;

public class User : IColleague
{
    private readonly IMediator _mediator;
    private readonly string _name;

    public User(string name, IMediator mediator)
    {
        _name = name;
        _mediator = mediator;
        mediator.Register(this);
    }

    public void Send(string message)
    {
        Console.WriteLine($"{_name} trimite: {message}");
        _mediator.Notify(this, message);
    }

    public void Receive(string message)
    {
        Console.WriteLine($"{_name} primește: {message}");
    }
}