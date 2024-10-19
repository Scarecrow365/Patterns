using System;
using System.Collections.Generic;

namespace Refactoring.Ex1.Fixed_5Builder.Command
{
  public class BattleCommand : ICommand<IEntity>
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

      public Builder(List<IEntity> targets = default)
      {
        command.targets = targets ?? new List<IEntity>();
      }

      public Builder WithAction(Action<IEntity> action)
      {
        command.action = action;
        return this;
      }

      public BattleCommand Build()
      {
        return command;
      }
    }
  }
}