using System.Collections.Generic;
using Refactoring.Ex1.Fixed_1Flyweight.SO;
using UnityEngine;

namespace Refactoring.Ex1.Fixed_1Flyweight
{
  public class EnemySpawner : MonoBehaviour
  {
    public List<EnemyConfig> EnemyConfigs;

    private void Start()
    {
      SpawnEnemies();
    }

    private void SpawnEnemies()
    {
      for (var i = 0; i < 10; i++)
      {
        GameObject enemy = Instantiate(EnemyConfigs[i % EnemyConfigs.Count].prefab);
        enemy.GetComponent<Enemy>().Initialize(EnemyConfigs[i % EnemyConfigs.Count]);
        enemy.transform.position = new Vector3(i * 2f, 0, 0);
      }
    }
  }
}