using UnityEngine;

namespace Mediator.Ex2
{
    public class JTPoorman : Colleague
    {
        public JTPoorman(IMediator mediator) : base(mediator)
        {
            Debug.Log("JT Poorman signed up with the stockexange");
        }
    }
}