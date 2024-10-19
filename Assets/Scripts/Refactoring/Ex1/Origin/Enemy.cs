using UnityEngine;

namespace Refactoring.Ex1.Origin
{
  public class Enemy
  {
    public float attackRange;
    public int damage;
    public int health;
    public string type;

    public void LogInfo()
    {
      Debug.Log($"Enemy info: type={type}, health={health}, damage={damage}, attack range={attackRange}");
    }

    public void PerformAction(string action)
    {
      Debug.Log($"{type} performs action: {action}");
    }
  }
}