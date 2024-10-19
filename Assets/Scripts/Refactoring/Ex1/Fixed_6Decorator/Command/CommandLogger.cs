using UnityEngine;

namespace Refactoring.Ex1.Fixed_6Decorator.Command
{
  public class CommandLogger : ICommand
  {
    private readonly ICommand command;

    public CommandLogger(ICommand command)
    {
      this.command = command;
    }

    public void Execute()
    {
      Debug.Log($"Command executed: {command.GetType().Name}");
      command.Execute();
    }
  }
}