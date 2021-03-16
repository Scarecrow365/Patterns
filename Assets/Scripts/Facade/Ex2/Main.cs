using UnityEngine;

namespace Facade.Ex2
{
    public class Main : MonoBehaviour
    {
        private void Start()
        {
            var mortgage = new Mortgage();
            var customer = new Customer("John");

            var eligible = mortgage.IsEligible(customer, 12000);

            Debug.Log(eligible);
        }
    }
}