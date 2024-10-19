using Refactoring.Ex1.Fixed_5Builder.SO.Enemies;
using UnityEngine;

namespace Refactoring.Ex1.Fixed_5Builder.Factory
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