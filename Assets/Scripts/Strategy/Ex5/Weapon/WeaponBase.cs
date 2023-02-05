using Strategy.Ex5.Interfaces;

namespace Strategy.Ex5.Weapon
{
    internal abstract class WeaponBase : IAttack
    {
        protected int Damage = 0;
        protected IRune CurrentRune;

        public virtual void DoAttack(ITarget target)
        {
            target.GetDamage(Damage, CurrentRune);
        }

        public void SetDamageType(IRune runeType)
        {
            CurrentRune = runeType;
        }
    }
}