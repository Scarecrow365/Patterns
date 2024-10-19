using Refactoring.Ex1.Fixed_2Factory.SO;
using UnityEngine;

namespace Refactoring.Ex1.Fixed_2Factory.Factory
{
  public class EnemyFactory : IEnemyFactory
  {
    public Enemy Create(EnemyConfig config)
    {
      GameObject enemy = Object.Instantiate(config.prefab);
      var enemyComponent = enemy.GetComponent<Enemy>();
      enemyComponent.Initialize(config);
      return enemyComponent;
    }
  }
}