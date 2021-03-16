using System;
using UnityEngine;

namespace Pool.Ex3
{
    public class Spawner : MonoBehaviour
    {
        private ObjectPooler _objectPooler;

        private void Start()
        {
            _objectPooler = ObjectPooler.Instance;
            _objectPooler.SpawnFromPool("Cube", transform.position, Quaternion.identity);
        }
    }
}