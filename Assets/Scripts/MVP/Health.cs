using System;
using UnityEngine;

namespace MVP
{
    public class Health
    {
        private const int minHealth = 0;
        private const int maxHealth = 100;

        public int MinHealth => minHealth;
        public int MaxHealth => maxHealth;

        public event Action HealthChanged;

        public int CurrentHealth { get; private set; } = maxHealth;

        public void Increment(int amount)
        {
            CurrentHealth += amount;
            CurrentHealth = Mathf.Clamp(CurrentHealth, minHealth, maxHealth);
            UpdateHealth();
        }

        public void Decrement(int amount)
        {
            CurrentHealth -= amount;
            CurrentHealth = Mathf.Clamp(CurrentHealth, minHealth, maxHealth);
            UpdateHealth();
        }

        public void Restore()
        {
            CurrentHealth = maxHealth;
            UpdateHealth();
        }

        private void UpdateHealth()
        {
            HealthChanged?.Invoke();
        }
    }
}