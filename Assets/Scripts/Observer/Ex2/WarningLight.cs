using System;
using UnityEngine;

namespace Observer.Ex2
{
    public class WarningLight : MonoBehaviour
    {
        private void OnEnable()
        {
            Timer.OnHalfStarted += BlinkLight;
        }

        private void OnDisable()
        {
            Timer.OnHalfStarted -= BlinkLight;
        }

        private void BlinkLight()
        {
            Debug.Log("[WARNING LIGHT] : It's half-time, blinking the warning light!");
        }
    }
}