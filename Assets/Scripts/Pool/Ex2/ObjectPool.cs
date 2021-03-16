using System;
using System.Collections.Generic;
using UnityEngine;

namespace Pool.Ex2
{
    public class ObjectPool : MonoBehaviour
    {
        [SerializeField] private GameObject[] _objects;

        private Dictionary<string, Queue<IPoolable>> _objDictionary = new Dictionary<string, Queue<IPoolable>>();
        public static ObjectPool Instance { get; private set; }

        private void Awake()
        {
            if (Instance)
            {
                DestroyImmediate(this);
            }
            else
            {
                Instance = this;
            }
        }

        private void Start()
        {
            foreach (var obj in _objects)
            {
                var poolObj = obj.GetComponent<IPoolable>();
                if (poolObj == null)
                {
                    continue;
                }

                var queue = new Queue<IPoolable>();
                for (int i = 0; i < poolObj.ObjCount; i++)
                {
                    var newObj = Instantiate(obj);
                    obj.SetActive(false);
                    queue.Enqueue(newObj.GetComponent<IPoolable>());
                }
                _objDictionary.Add(poolObj.PoolId, queue);
            }
        }

        public IPoolable GetObjects(string poolId)
        {
            if (string.IsNullOrEmpty(poolId))
            {
                return null;
            }

            if (!_objDictionary.ContainsKey(poolId))
            {
                return null;
            }

            var obj = _objDictionary[poolId].Dequeue();
            _objDictionary[poolId].Enqueue(obj);
            return obj;
        }
    }
}