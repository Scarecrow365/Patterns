using UnityEngine;

namespace Pool.Ex4.V1
{
    public class PooledObject : MonoBehaviour
    {
        public ObjectPool Pool { get; set; }

        public void Release()
        {
            Pool.ReturnToPool(this);
        }
    }
}