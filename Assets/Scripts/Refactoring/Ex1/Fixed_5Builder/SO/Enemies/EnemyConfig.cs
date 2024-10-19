using UnityEngine;

namespace Refactoring.Ex1.Fixed_5Builder.SO.Enemies
{
  //[CreateAssetMenu(fileName = "EnemyConfig", menuName = "Enemy config")]
  public class EnemyConfig : ScriptableObject
  {
    public Enemy prefab;
    public string type;
    public int health;
    public int damage;
    public float attackRange;
  }
}