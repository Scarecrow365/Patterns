using UnityEngine;

namespace MVP
{
    public class Main : MonoBehaviour
    {
        [SerializeField] private HealthView healthViewPrefab;

        private void Start()
        {
            InitHealthSystem();
        }

        private void InitHealthSystem()
        {
            Health health = new();
            HealthView healthView = Instantiate(healthViewPrefab);
            HealthPresenter healthPresenter = new HealthPresenter(health, healthView);
        }
    }
}