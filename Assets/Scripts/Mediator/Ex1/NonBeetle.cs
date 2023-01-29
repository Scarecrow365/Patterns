using UnityEngine;

namespace Mediator.Ex1
{
    internal class NonBeetle : Participant
    {
        public NonBeetle(string name) : base(name)
        {
        }

        public override void Receive(string from, string message)
        {
            base.Receive(from, message);
            Debug.Log("To a non-Beetle: " + ModifyMessage);
        }
    }
}