using System.Collections.Generic;
using System.Text;
using Refactoring.Ex1.Fixed_6Decorator.Command;
using Refactoring.Ex1.Fixed_6Decorator.SO.Enemies;
using UnityEngine;

namespace Refactoring.Ex1.Fixed_6Decorator
{
  public class Enemy : MonoBehaviour, IEntity
  {
    private readonly Queue<ICommand> commandQueue = new();
    public EnemyConfig Config { get; private set; }

    private void Update()
    {
      ExecuteCommand();
    }

    public void Initialize(EnemyConfig enemyConfig)
    {
      Config = enemyConfig;

      LogInfo();
      CreateTestCommand();
    }

    public void QueueCommand(ICommand command)
    {
      commandQueue.Enqueue(command);
    }

    public void ExecuteCommand()
    {
      if (commandQueue.Count > 0) commandQueue.Dequeue()?.Execute();
    }

    private void CreateTestCommand()
    {
      ICommand newCommand = new BattleCommand.Builder(new List<IEntity> { this })
        .WithAction(_ => Debug.Log($"{Config.type} does something"))
        .WithLogger()
        .Build();

      QueueCommand(newCommand);
    }

    private void LogInfo()
    {
      StringBuilder sr = new();
      sr.Append("Enemy info: ");
      sr.Append($"type={Config.type}; ");
      sr.Append($"health={Config.health}; ");
      sr.Append($"damage={Config.damage}; ");
      sr.Append($"attackRange={Config.attackRange}");
      Debug.Log(sr);
    }
  }
}