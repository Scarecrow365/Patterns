using System;
using UnityEngine;

namespace Observer.Ex3
{
    public class Subject : MonoBehaviour
    {
        public event Action ThingHappened;
        
        public void DoThing()
        {
            ThingHappened?.Invoke();
        }
    }
}