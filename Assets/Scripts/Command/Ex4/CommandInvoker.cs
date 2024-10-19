using System.Collections.Generic;

namespace Command.Ex4
{
    public class CommandInvoker
    {
        private readonly Stack<ICommand> undoStack = new();

        public void ExecuteCommand(ICommand command)
        {
            command.Execute();
            undoStack.Push(command);
        }

        public void UndoCommand()
        {
            if (undoStack.Count <= 0) return;

            ICommand activeCommand = undoStack.Pop();
            activeCommand.Undo();
        }
    }
}