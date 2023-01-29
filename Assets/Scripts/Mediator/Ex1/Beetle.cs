using UnityEngine;

namespace Mediator.Ex1
{
    internal class Beetle : Participant
    {
        public Beetle(string name) : base(name)
        {
        }

        public override void Receive(string from, string message)
        {
            base.Receive(from, message);
            Debug.Log("To a Beetle: " + ModifyMessage);
        }
    }
}