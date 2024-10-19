﻿using UnityEngine;

namespace Refactoring.Ex1.Fixed_6Decorator.SO.Placements
{
  [CreateAssetMenu(fileName = "DefaultPlacer", menuName = "Placements/Default Placer")]
  public class PlacementStrategy : ScriptableObject
  {
    public virtual Vector3 SetPosition(Vector3 origin)
    {
      return origin;
    }
  }
}