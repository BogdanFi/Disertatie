namespace Mediator.Interfaces;

public interface IColleague
{
    void Send(string message);
    void Receive(string message);
}