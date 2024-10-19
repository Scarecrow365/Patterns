using System;
using System.Collections.Generic;

namespace Refactoring.Ex1.Fixed_6Decorator.Command
{
  public class BattleCommand : ICommand
  {
    private Action<IEntity> action = delegate { };
    private List<IEntity> targets;

    public void Execute()
    {
      foreach (IEntity target in targets) action.Invoke(target);
    }

    public class Builder
    {
      private readonly BattleCommand command = new();
      private bool isLoggerEnabled;

      public Builder(List<IEntity> targets = default)
      {
        command.targets = targets ?? new List<IEntity>();
      }

      public Builder WithAction(Action<IEntity> action)
      {
        command.action = action;
        return this;
      }

      public Builder WithLogger()
      {
        isLoggerEnabled = true;
        return this;
      }

      public ICommand Build()
      {
        return isLoggerEnabled ? new CommandLogger(command) : command;
      }
    }
  }
}