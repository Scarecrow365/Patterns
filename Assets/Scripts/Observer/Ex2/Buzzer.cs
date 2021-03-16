using UnityEngine;

namespace Observer.Ex2
{
    public class Buzzer : MonoBehaviour
    {
        private void OnEnable()
        {
            Timer.OnTimerStarted += PlayStartBuzzer;
            Timer.OnTimerEnded += PlayEndBuzzer;
        }

        private void OnDisable()
        {
            Timer.OnTimerStarted -= PlayStartBuzzer;
            Timer.OnTimerEnded -= PlayEndBuzzer;
        }

        private void PlayStartBuzzer()
        {
            Debug.Log("[BUZZER] : Play start buzzer!");
        }

        private void PlayEndBuzzer()
        {
            Debug.Log("[BUZZER] : Play end buzzer!");
        }
    }
}