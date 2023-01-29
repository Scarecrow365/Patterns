namespace Mediator.Ex3
{
    internal abstract class BaseMediator
    {
        public abstract void Send(string message, BaseColleague baseColleague);
    }
}