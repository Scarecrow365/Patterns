using System;
using System.Collections.Generic;
using UnityEngine;

namespace Pool.Ex1
{
    public class ObjectPool : MonoBehaviour
    {
        public GameObject[] Objects;
        public List<GameObject>[] pooledObjects;

        public int[] amountToBuffer;
        public int defaultBufferAmount = 3;

        protected GameObject containerObject;

        private void Start()
        {
            containerObject = new GameObject("ObjectPool");
            pooledObjects = new List<GameObject>[Objects.Length];

            var i = 0;
            foreach (var obj in Objects)
            {
                pooledObjects[i] = new List<GameObject>();

                var bufferAmount = i < amountToBuffer.Length ? amountToBuffer[i] : defaultBufferAmount;

                for (int j = 0; j < bufferAmount; j++)
                {
                    var newObj = Instantiate(obj);
                    newObj.name = obj.name;
                    PoolObject(newObj);
                }

                i++;
            }
        }

        public void PoolObject(GameObject newObj)
        {
            for (int i = 0; i < Objects.Length; i++)
            {
                if (Objects[i].name == newObj.name)
                {
                    newObj.SetActive(false);
                    newObj.transform.parent = containerObject.transform;
                    pooledObjects[i].Add(newObj);
                    return;
                }
            }

            Destroy(newObj);

        }

        public GameObject PullObject(string objectType)
        {
            var onlyPooled = false;
            for (int i = 0; i < Objects.Length; i++)
            {
                var prefab = Objects[i];

                if (prefab.name == objectType)
                {
                    if (pooledObjects[i].Count > 0)
                    {
                        var pooledObj = pooledObjects[i][0];
                        pooledObj.SetActive(true);
                        pooledObj.transform.parent = null;

                        pooledObjects[i].Remove(pooledObj);
                        return pooledObj;
                    }
                    else if (!onlyPooled)
                    {
                        return Instantiate(Objects[i]);
                    }

                    break;
                }
            }

            return null;
        }

    }
}