using UnityEngine;

namespace Factory.Ex1
{
    public class ProductA : MonoBehaviour, IProduct
    {
        [SerializeField] private string productName = "ProductA";
        
        public string ProductName { get => productName; set => productName = value ; }
        
        private ParticleSystem particleSystem;
        
        public void Initialize()
        {
            gameObject.name = productName;
            
            particleSystem = gameObject.AddComponent<ParticleSystem>();
            particleSystem?.Stop();
            particleSystem?.Play();
        }
    }
}