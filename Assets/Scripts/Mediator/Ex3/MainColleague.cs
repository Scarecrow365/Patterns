using UnityEngine;

namespace Mediator.Ex3
{
    internal class MainColleague : BaseColleague
    {
        public MainColleague(BaseMediator baseMediator) : base(baseMediator)
        {
        }

        public void Send(string message)
        {
            BaseMediator.Send(message, this);
        }

        public void Notify(string message)
        {
            Debug.Log("Colleague1 gets message: " + message);
        }
    }
}