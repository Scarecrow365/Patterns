using System.Collections.Generic;
using Refactoring.Ex1.Fixed_5Builder.Command;
using Refactoring.Ex1.Fixed_5Builder.SO.Enemies;
using UnityEngine;

namespace Refactoring.Ex1.Fixed_5Builder
{
  public class Enemy : MonoBehaviour, IEntity
  {
    private readonly Queue<ICommand<IEntity>> commandQueue = new();
    public EnemyConfig Config { get; private set; }

    private void Update()
    {
      BattleCommand newCommand = new BattleCommand.Builder(new List<IEntity> { this })
        .WithAction(_ => Debug.Log($"{Config.type} does something"))
        .Build();

      QueueCommand(newCommand);
    }

    public void Initialize(EnemyConfig enemyConfig)
    {
      Config = enemyConfig;
    }

    public void QueueCommand(ICommand<IEntity> command)
    {
      commandQueue.Enqueue(command);
    }

    public void ExecuteCommand()
    {
      if (commandQueue.Count > 0) commandQueue.Dequeue()?.Execute();
    }

    public void LogInfo()
    {
      //Debug.Log($"Enemy info: type={type}; health={health}; damage={damage}; attackRange={attackRange}");
    }

    public void PerformAction(string action)
    {
      Debug.Log($"{Config.type} perform action: {action}");
    }
  }
}