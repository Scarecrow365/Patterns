using UnityEngine;

namespace Observer.Ex2
{
    public class Notifer : MonoBehaviour
    {
        private void OnEnable()
        {
            Timer.OnTimerEnded += ShowGameOverPopUp;
        }

        private void OnDisable()
        {
            Timer.OnTimerEnded -= ShowGameOverPopUp;
        }

        private void ShowGameOverPopUp()
        {
            Debug.Log("[NOTIFIER] : Show game over pop up!");
        }
    }
}