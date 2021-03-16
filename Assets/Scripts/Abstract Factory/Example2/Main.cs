using UnityEngine;

namespace AbstractFabric.Example2
{
    public class Main : MonoBehaviour
    {

        private void Start()
        {
            var ufoBuilder = new UFOShipBuilding();
            ufoBuilder.OrderShip();
        }
    }
}
