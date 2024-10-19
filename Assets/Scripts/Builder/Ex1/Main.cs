using UnityEngine;

namespace Builder.Ex1
{
    public class Main : MonoBehaviour
    {
        private void Start()
        {
            CreateEnemy();
        }

        private static void CreateEnemy()
        {
            var enemyData = new EnemyData.Builder()
                .WithName("TestName")
                .WithHealth(1)
                .WithDamage(1000)
                .WithSpeed(2)
                .IsBoss(false)
                .Build();

            var enemy = new GameObject($"Enemy-{enemyData.Name}").AddComponent<Enemy>();
            enemy.Construct(enemyData);

            Debug.Log($"Created enemy: {enemy.Data.Name}. HP - {enemy.Data.Health}, Speed - {enemy.Data.Speed}");
        }
    }
}
