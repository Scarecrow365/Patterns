﻿namespace State.Ex3
{
    public class JumpState : IState
    {
        private PlayerController player;
        public JumpState(PlayerController player)
        {
            this.player = player;
        }
        public void Enter()
        {
        }
        public void Update()
        {
        }
        
        public void Exit()
        {
        }
    }
}