using Refactoring.Ex1.Fixed_6Decorator.SO.Enemies;
using UnityEngine;

namespace Refactoring.Ex1.Fixed_6Decorator.Factory
{
  public class EnemyFactory : IEnemyFactory
  {
    public Enemy Create(EnemyConfig config)
    {
      Enemy enemy = Object.Instantiate(config.prefab);
      enemy.Initialize(config);
      return enemy;
    }
  }
}