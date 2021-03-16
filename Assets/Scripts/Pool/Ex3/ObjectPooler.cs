using System.Collections.Generic;
using UnityEngine;

namespace Pool.Ex3
{
    public class ObjectPooler : MonoBehaviour
    {
        public List<Pool> pools;
        public Dictionary<string, Queue<GameObject>> PoolDictionary;

        public static ObjectPooler Instance;

        private void Awake()
        {
            Instance = this;
        }

        private void Start()
        {
            PoolDictionary = new Dictionary<string, Queue<GameObject>>();

            foreach (var pool in pools)
            {
                var objectPool = new Queue<GameObject>();

                for (var i = 0; i < pool.size; i++)
                {
                    var newObj = Instantiate(pool.prefab);
                    newObj.SetActive(false);
                    objectPool.Enqueue(newObj);
                }

                PoolDictionary.Add(pool.tag, objectPool);
            }
        }

        public GameObject SpawnFromPool(string key, Vector3 position, Quaternion quaternion)
        {
            if (!PoolDictionary.ContainsKey(key))
            {
                return null;
            }

            var objectToSpawn = PoolDictionary[key].Dequeue();

            objectToSpawn.SetActive(true);
            objectToSpawn.transform.position = position;
            objectToSpawn.transform.rotation = quaternion;

            var pooledObj = objectToSpawn.GetComponent<IPooledObject>();
            pooledObj?.OnObjectSpawn();

            PoolDictionary[key].Enqueue(objectToSpawn);
            return objectToSpawn;
        }
    }
}