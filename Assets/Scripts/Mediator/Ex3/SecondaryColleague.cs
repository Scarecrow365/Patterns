using UnityEngine;

namespace Mediator.Ex3
{
    internal class SecondaryColleague : BaseColleague
    {
        public SecondaryColleague(BaseMediator baseMediator) : base(baseMediator)
        {
        }

        public void Send(string message)
        {
            BaseMediator.Send(message, this);
        }

        public void Notify(string message)
        {
            Debug.Log("Colleague2 gets message: " + message);
        }
    }
}