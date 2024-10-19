using System;

namespace State.Ex3
{
    [Serializable]
    public class StateMachine
    {
        public IState CurrentState { get; private set; }

        public WalkState WalkState;
        public JumpState JumpState;
        public IdleState IdleState;

        public StateMachine(PlayerController player)
        {
            WalkState = new WalkState(player);
            JumpState = new JumpState(player);
            IdleState = new IdleState(player);
        }

        public void Initialize(IState startingState)
        {
            CurrentState = startingState;
            startingState.Enter();
        }

        public void TransitionTo(IState nextState)
        {
            CurrentState.Exit();
            CurrentState = nextState;
            nextState.Enter();
        }

        public void Update()
        {
            if (CurrentState != null)
            {
                CurrentState.Update();
            }
        }
    }
}