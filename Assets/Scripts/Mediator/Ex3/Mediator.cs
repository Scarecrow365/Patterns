namespace Mediator.Ex3
{
    internal class Mediator : BaseMediator
    {
        public MainColleague Colleague1 { get; set; }
        public SecondaryColleague Colleague2 { get; set; }

        public override void Send(string message, BaseColleague baseColleague)
        {
            if (baseColleague == Colleague1)
                Colleague2.Notify(message);
            else
                Colleague1.Notify(message);
        }
    }
}