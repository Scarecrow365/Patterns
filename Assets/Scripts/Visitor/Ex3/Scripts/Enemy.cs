using Visitor.Ex3.Scripts.Abstraction;

namespace Visitor.Ex3.Scripts
{
    public class Enemy : IDamageable
    {
        public int Health = 100;

        public void ReceiveDamage(int amount) => Health -= amount;
    }
}