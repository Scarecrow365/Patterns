using UnityEngine;

namespace Observer.Ex1
{
    public class Main : MonoBehaviour
    {
        private void Start()
        {
            var ibm = new IbmStock("IBM", 120.00);
            var investor = new Investor("Shepard");
            ibm.Attach(investor);
            ibm.Attach(new Investor("Stark"));

            ibm.Price = 120.01;
            ibm.Price = 120.99;
            ibm.Price = 130;
            ibm.Price = 140;
            ibm.Price = 120;

            ibm.Detach(investor);
        }
    }
}