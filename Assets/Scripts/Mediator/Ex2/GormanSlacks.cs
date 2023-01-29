using UnityEngine;

namespace Mediator.Ex2
{
    public class GormanSlacks : Colleague
    {
        public GormanSlacks(IMediator mediator) : base(mediator)
        {
            Debug.Log("Gorman Slacks signed up with the stockexange");
        }
    }
}