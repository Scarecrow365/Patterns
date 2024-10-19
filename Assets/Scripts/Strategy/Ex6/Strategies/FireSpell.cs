using UnityEngine;

namespace Strategy.Ex6.Strategies
{
  [CreateAssetMenu(fileName = "FireSpellStrategy", menuName = "Spells/Fire Spell")]
  public class FireSpell : SpellStrategy
  {
    public override void CastSpell()
    {
      Debug.Log("Fire");
    }
  }
}