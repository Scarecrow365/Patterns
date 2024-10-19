using System;
using UnityEngine;
using UnityEngine.UI;

namespace MVP
{
    public class HealthView : MonoBehaviour
    {
        [SerializeField] private Slider healthSlider;
        [SerializeField] private Button restoreButton;
        [SerializeField] private Button healButton;
        [SerializeField] private Button damageButton;

        public event Action OnRestorePressed;
        public event Action<int> OnHealPressed;
        public event Action<int> OnDamagePressed;

        public void Start()
        {
            healButton.onClick.AddListener(() => OnHealPressed?.Invoke(10));
            damageButton.onClick.AddListener(() => OnDamagePressed?.Invoke(10));
            restoreButton.onClick.AddListener(() => OnRestorePressed?.Invoke());
        }

        public void Init(int minHealth, int maxHealth)
        {
            healthSlider.minValue = minHealth;
            healthSlider.maxValue = maxHealth;
        }

        public void UpdateView(int currentHealth)
        {
            if (healthSlider != null && healthSlider.maxValue > 0)
                healthSlider.value = currentHealth / healthSlider.maxValue * healthSlider.maxValue;
        }
    }
}