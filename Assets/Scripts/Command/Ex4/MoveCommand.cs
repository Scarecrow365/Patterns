using UnityEngine;

namespace Command.Ex4
{
    public class MoveCommand : ICommand
    {
        private readonly PlayerMover playerMover;
        private readonly Vector3 movement;

        public MoveCommand(PlayerMover player, Vector3 moveVector)
        {
            playerMover = player;
            movement = moveVector;
        }

        public void Execute()
        {
            playerMover.Move(movement);
        }

        public void Undo()
        {
            playerMover.Move(-movement);
        }
    }
}