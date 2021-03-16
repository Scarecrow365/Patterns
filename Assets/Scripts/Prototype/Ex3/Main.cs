using UnityEngine;

namespace Prototype.Ex3
{
    public class Main : MonoBehaviour
    {
        private void Start()
        {
            var factory = new CloneFactory();
            var sally = new Sheep();
            var clonedSheep = (Sheep)factory.GetClone(sally);
            
            Debug.Log("Sally Hash: " + sally.GetHashCode() + " - Cloned Sheep Hash: " + clonedSheep.GetHashCode());
        }
    }
}