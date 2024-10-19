using UnityEngine;

namespace State.Ex3
{
    public class PlayerController : MonoBehaviour
    {
        private StateMachine stateMachine;

        private void Start()
        {
            stateMachine = new StateMachine(this);
            stateMachine.Initialize(stateMachine.IdleState);
        }

        private void Update()
        {
            stateMachine.Update();
            GetInputWalk();
            GetInputJump();
        }

        private void GetInputWalk() => stateMachine.TransitionTo(stateMachine.WalkState);

        private void GetInputJump() => stateMachine.TransitionTo(stateMachine.JumpState);
    }
}