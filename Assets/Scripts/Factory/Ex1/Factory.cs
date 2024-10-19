using UnityEngine;

namespace Factory.Ex1
{
    public abstract class Factory : MonoBehaviour
    {
        public abstract IProduct GetProduct(Vector3 position);
    }
}