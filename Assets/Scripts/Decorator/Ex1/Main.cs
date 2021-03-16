using System;
using UnityEngine;

namespace Decorator.Ex1
{
    public class Main : MonoBehaviour
    {
        private void Start()
        {
            IRifle rifle = new BasicRifle();
            Debug.Log(rifle.GetAccuracy());

            rifle = new WithScope(rifle);
            Debug.Log(rifle.GetAccuracy());

            rifle = new WithStabilizer(rifle);
            Debug.Log(rifle.GetAccuracy());
        }
    }
}