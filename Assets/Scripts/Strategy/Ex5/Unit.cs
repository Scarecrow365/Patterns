using Strategy.Ex5.Interfaces;
using Strategy.Ex5.Weapon;
using UnityEngine;

namespace Strategy.Ex5
{
    internal class Unit : ITarget
    {
        public string Name;
        public int Mana;
        public int Health;
        
        public WeaponBase LeftHand;
        public WeaponBase RightHand;
        
        public ITarget Target;

        public void AttackLeftHand() => LeftHand.DoAttack(Target);
        public void AttackRightHand() => RightHand.DoAttack(Target);

        public void GetDamage(int damage, IRune runeAttack)
        {
            string runeAttackName = "by physics weapon";
            if (runeAttack != null)
                runeAttackName = "and rune attack = " + runeAttack.GetType().Name;
            
            Debug.Log($"{Name} got damage {damage} {runeAttackName}");
        }
    }
}