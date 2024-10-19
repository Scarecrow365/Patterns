using System;

namespace MVP
{
    public class HealthPresenter : IDisposable
    {
        private readonly Health health;
        private readonly HealthView view;

        public HealthPresenter(Health health, HealthView view)
        {
            this.health = health;
            this.view = view;

            InitView();
            Subscribe();
        }

        private void InitView()
        {
            view.Init(health.MinHealth, health.MaxHealth);
        }

        private void Reset()
        {
            health?.Restore();
        }

        private void OnHealthChanged()
        {
            UpdateView();
        }

        private void Heal(int amount)
        {
            health?.Increment(amount);
        }

        private void Damage(int amount)
        {
            health?.Decrement(amount);
        }

        private void UpdateView()
        {
            view.UpdateView(health.CurrentHealth);
        }

        private void Subscribe()
        {
            if (health != null) health.HealthChanged += OnHealthChanged;

            if (view != null)
            {
                view.OnHealPressed += Heal;
                view.OnDamagePressed += Damage;
                view.OnRestorePressed += Reset;
            }

            UpdateView();
        }

        private void Unsubscribe()
        {
            if (health != null) health.HealthChanged -= OnHealthChanged;

            if (view == null) return;

            view.OnHealPressed -= Heal;
            view.OnDamagePressed -= Damage;
            view.OnRestorePressed -= Reset;
        }

        public void Dispose()
        {
            Unsubscribe();
        }
    }
}