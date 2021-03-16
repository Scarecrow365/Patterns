using UnityEngine;

namespace Prototype.Ex1
{
    public class Enemy : MonoBehaviour, ICopyable
    {
        public ICopyable Copy()
        {
            return Instantiate(this);
        }
    }
}