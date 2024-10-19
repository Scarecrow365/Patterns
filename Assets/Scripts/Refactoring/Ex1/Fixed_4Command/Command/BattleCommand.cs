using System;
using System.Collections.Generic;

namespace Refactoring.Ex1.Fixed_4Command.Command
{
  public class BattleCommand : ICommand<IEntity>
  {
    private readonly Action<IEntity> action = delegate { };
    private List<IEntity> targets;

    public void Execute()
    {
      foreach (IEntity target in targets) action.Invoke(target);
    }
  }
}