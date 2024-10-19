using UnityEngine;

namespace Strategy.Ex6.Strategies
{
  public abstract class SpellStrategy : ScriptableObject
  {
    public abstract void CastSpell();
  }
}