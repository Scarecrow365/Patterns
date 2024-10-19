using Refactoring.Ex1.Extension;
using UnityEngine;

namespace Refactoring.Ex1.Fixed_6Decorator.SO.Placements
{
  [CreateAssetMenu(fileName = "RandomCirclePlacer", menuName = "Placements/Random Circle Placer")]
  public class RandomCirclePlacer : PlacementStrategy
  {
    public float minDistance;
    public float maxDistance = 10;

    public override Vector3 SetPosition(Vector3 origin)
    {
      return origin.RandomPointInAnnulus(minDistance, maxDistance);
    }
  }
}