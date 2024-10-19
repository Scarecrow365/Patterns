using UnityEngine;
using UnityEngine.Pool;

namespace Pool.Ex4.V2
{
    public class RevisedGun : MonoBehaviour
    {
        private IObjectPool<RevisedProjectile> objectPool;

        [SerializeField] private RevisedProjectile projectilePrefab;
        [SerializeField] private bool collectionCheck = true;
        [SerializeField] private int defaultCapacity = 20;
        [SerializeField] private int maxSize = 100;

        private void Awake()
        {
            objectPool = new ObjectPool<RevisedProjectile>(CreateProjectile,
                OnGetFromPool, OnReleaseToPool, OnDestroyPooledObject,
                collectionCheck, defaultCapacity, maxSize);
        }

        private RevisedProjectile CreateProjectile()
        {
            RevisedProjectile projectileInstance = Instantiate(projectilePrefab);
            projectileInstance.ObjectPool = objectPool;
            return projectileInstance;
        }

        private static void OnReleaseToPool(RevisedProjectile pooledObject) => pooledObject.gameObject.SetActive(false);

        private static void OnGetFromPool(RevisedProjectile pooledObject) => pooledObject.gameObject.SetActive(true);

        private static void OnDestroyPooledObject(RevisedProjectile pooledObject) => Destroy(pooledObject.gameObject);
    }
}