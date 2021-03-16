using UnityEngine;

namespace Abstract_Fabric
{
    public class Main : MonoBehaviour
    {
        private void Start()
        {
            var russia = new Russia();
            var world = new AnimalWorld(russia);
            world.RunFoodChain();
        }
    }
}