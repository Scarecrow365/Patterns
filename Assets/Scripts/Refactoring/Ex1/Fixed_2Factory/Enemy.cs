using Refactoring.Ex1.Fixed_2Factory.SO;
using UnityEngine;

namespace Refactoring.Ex1.Fixed_2Factory
{
  public class Enemy : MonoBehaviour
  {
    public EnemyConfig Config { get; private set; }

    public void Initialize(EnemyConfig enemyConfig)
    {
      Config = enemyConfig;
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