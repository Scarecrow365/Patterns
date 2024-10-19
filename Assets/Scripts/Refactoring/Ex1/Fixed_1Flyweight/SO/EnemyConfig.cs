using UnityEngine;

namespace Refactoring.Ex1.Fixed_1Flyweight.SO
{
  //[CreateAssetMenu(fileName = "EnemyConfig", menuName = "Enemy config")]
  public class EnemyConfig : ScriptableObject
  {
    public GameObject prefab;
    public string type;
    public int health;
    public int damage;
    public float attackRange;
  }
}