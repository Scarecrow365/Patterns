using UnityEngine;

namespace Strategy.Ex4
{
    public class SeekWithHeat : ISeekBehaviour
    {
        public void Seek()
        {
            Debug.Log("Seeking target with heat signature.");
        }
    }
}