using UnityEngine;

namespace Command.Ex4
{
    public class InputManager : MonoBehaviour
    {
        [SerializeField] private PlayerMover playerMover;

        private CommandInvoker playerMoverCommands;

        private void Start()
        {
            playerMoverCommands = new CommandInvoker();
        }

        private void RunPlayerCommand(Vector3 movement)
        {
            if (playerMover == null) return;
            if (!playerMover.IsValidMove(movement)) return;

            ICommand command = new MoveCommand(playerMover, movement);
            playerMoverCommands.ExecuteCommand(command);
        }
        
        private void OnUndoPressed()
        {
            if (playerMover == null) return;
            playerMoverCommands.UndoCommand();
        }
    }
}