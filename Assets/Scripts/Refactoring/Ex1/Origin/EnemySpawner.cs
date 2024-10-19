using UnityEngine;

namespace Refactoring.Ex1.Origin
{
  public class EnemySpawner : MonoBehaviour
  {
    public GameObject meleeEnemyPrefab;
    public GameObject rangedEnemyPrefab;
    public GameObject bossEnemyPrefab;

    private void Start()
    {
      SpawnEnemies();
    }

    private void SpawnEnemies()
    {
      for (var i = 0; i < 10; i++)
      {
        GameObject enemy;
        if (i % 3 == 0)
        {
          enemy = Instantiate(meleeEnemyPrefab);
          SetupMeleeEnemy(enemy);
        }
        else if (i % 3 == 1)
        {
          enemy = Instantiate(rangedEnemyPrefab);
          SetupRangedEnemy(enemy);
        }
        else
        {
          enemy = Instantiate(bossEnemyPrefab);
          SetupBossEnemy(enemy);
        }
      }
    }

    private void SetupMeleeEnemy(GameObject enemy)
    {
      var enemyComponent = enemy.GetComponent<Enemy>();
      enemyComponent.type = "Melee";
      enemyComponent.health = 100;
      enemyComponent.damage = 20;
      enemyComponent.attackRange = 2f;
      enemyComponent.LogInfo();
    }

    private void SetupRangedEnemy(GameObject enemy)
    {
      var enemyComponent = enemy.GetComponent<Enemy>();
      enemyComponent.type = "Ranged";
      enemyComponent.health = 80;
      enemyComponent.damage = 15;
      enemyComponent.attackRange = 10f;
      enemyComponent.LogInfo();
    }

    private void SetupBossEnemy(GameObject enemy)
    {
      var enemyComponent = enemy.GetComponent<Enemy>();
      enemyComponent.type = "Boss";
      enemyComponent.health = 300;
      enemyComponent.damage = 50;
      enemyComponent.attackRange = 5f;
      enemyComponent.LogInfo();
    }
  }
}