using System.Collections.Generic;
using Refactoring.Ex1.Fixed_2Factory.Factory;
using Refactoring.Ex1.Fixed_2Factory.SO;
using UnityEngine;

namespace Refactoring.Ex1.Fixed_2Factory
{
  public class EnemySpawner : MonoBehaviour
  {
    public int maxEnemies = 10;
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
        enemy.transform.position = new Vector3(i * 2f, 0, 0);
      }
    }
  }
}