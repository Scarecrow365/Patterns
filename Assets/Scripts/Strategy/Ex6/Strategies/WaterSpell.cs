using UnityEngine;

namespace Strategy.Ex6.Strategies
{
  [CreateAssetMenu(fileName = "WaterSpellStrategy", menuName = "Spells/Water Spell")]
  public class WaterSpell : SpellStrategy
  {
    public override void CastSpell()
    {
      Debug.Log("Water");
    }
  }
}