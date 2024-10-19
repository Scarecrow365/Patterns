using UnityEngine;

namespace Builder.Ex1
{
  public class Enemy : MonoBehaviour
  {
    public EnemyData Data { get; private set; }

    public void Construct(EnemyData data)
    {
      Data = data;
    }
  }
}