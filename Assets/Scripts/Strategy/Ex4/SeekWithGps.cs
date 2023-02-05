using UnityEngine;

namespace Strategy.Ex4
{
    public class SeekWithGps : ISeekBehaviour
    {
        public void Seek()
        {
            Debug.Log("Seeking target with GPS coordinates.");
        }
    }
}