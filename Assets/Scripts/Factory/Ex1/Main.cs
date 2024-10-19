using UnityEngine;

namespace Factory.Ex1
{
    public class Main : MonoBehaviour
    {
        [SerializeField] private Factory factory;

        private void Start()
        {
            factory.GetProduct(Vector3.zero);
        }
    }
}