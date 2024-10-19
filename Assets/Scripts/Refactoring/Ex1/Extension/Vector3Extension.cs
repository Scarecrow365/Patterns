using UnityEngine;

namespace Refactoring.Ex1.Extension
{
  public static class Vector3Extension
  {
    public static Vector3 With(this Vector3 vector, float? x = null, float? y = null, float? z = null)
    {
      return new Vector3(x ?? vector.x, y ?? vector.y, z ?? vector.z);
    }

    public static Vector3 RandomPointInAnnulus(this Vector3 origin, float minRadius, float maxRadius)
    {
      float angle = Random.value * Mathf.PI * 2;
      Vector2 dir = new(Mathf.Cos(angle), Mathf.Sin(angle));

      float minRadius2 = minRadius * minRadius;
      float maxRadius2 = maxRadius * maxRadius;
      float distance = Mathf.Sqrt(Random.value * (maxRadius2 - minRadius2) + minRadius2);
      Vector3 position = Vector3.zero.With(dir.x, z: dir.y) * distance;
      return origin + position;
    }
  }
}