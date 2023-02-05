using Strategy.Ex5.Interfaces;
using Strategy.Ex5.Runes;
using Strategy.Ex5.Weapon;
using UnityEngine;

namespace Strategy.Ex5.Spells
{
    internal class PoisonAttack : WeaponBase
    {
        public PoisonAttack()
        {
            Damage = 10;
            CurrentRune = new PoisonRune();
        }
        
        public override void DoAttack(ITarget target)
        {
            base.DoAttack(target);
            Debug.Log("Doing Poison Attack");
        }
    }
}