using Strategy.Ex5.Interfaces;
using Strategy.Ex5.Runes;
using Strategy.Ex5.Weapon;
using UnityEngine;

namespace Strategy.Ex5.Spells
{
    internal class FireAttack : WeaponBase
    {
        public FireAttack()
        {
            Damage = 10;
            CurrentRune = new FireRune();
        }

        public override void DoAttack(ITarget target)
        {
            base.DoAttack(target);
            Debug.Log("Doing Fire Attack");
        }
    }
}