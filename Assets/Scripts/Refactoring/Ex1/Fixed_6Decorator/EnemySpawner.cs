using System.Collections.Generic;
using Refactoring.Ex1.Fixed_6Decorator.Factory;
using Refactoring.Ex1.Fixed_6Decorator.SO.Enemies;
using Refactoring.Ex1.Fixed_6Decorator.SO.Placements;
using UnityEngine;

namespace Refactoring.Ex1.Fixed_6Decorator
{
  public class EnemySpawner : MonoBehaviour
  {
    public int maxEnemies = 10;
    public PlacementStrategy PlacementStrategy;
    public List<EnemyConfig> EnemyConfigs;

    private readonly IEnemyFactory enemyFactory = new EnemyFactory();

    private void Start()
    {
      SpawnEnemies();
    }

    private void SpawnEnemies()
    {
      for (var i = 0; i < maxEnemies; i++)
      {
        Enemy enemy = enemyFactory.Create(EnemyConfigs[i % EnemyConfigs.Count]);
        enemy.transform.position = PlacementStrategy.SetPosition(Vector3.zero);
      }
    }
  }
}