using UnityEngine;

namespace Strategy.Ex4
{
    public class SeekWithSonar : ISeekBehaviour
    {
        public void Seek()
        {
            Debug.Log("Seeking target with sonar.");
        }
    }
}