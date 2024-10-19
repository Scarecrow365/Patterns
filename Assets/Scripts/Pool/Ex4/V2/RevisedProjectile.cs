using UnityEngine;
using UnityEngine.Pool;

namespace Pool.Ex4.V2
{
    public class RevisedProjectile : MonoBehaviour
    {
        public IObjectPool<RevisedProjectile> ObjectPool { get; set; }
    }
}