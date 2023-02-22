namespace Visitor.Ex3.Scripts.Abstraction
{
    public abstract class CharacterBase
    {
        public abstract int Level { get; protected set; }

        public abstract CharacterStats Stats { get; protected set; }

        public abstract void Attack(IDamageable other);

        protected abstract int CalculateDamage();

        public abstract void IncreaseLevel();
    }
}