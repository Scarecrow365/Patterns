using UnityEngine;

namespace Adapter.Ex1
{
    public class OnlinePerson : ScriptableObject
    {
        public string GetFirstName(int id)
        {
            return "John";
        }

        public string GetLastName(int id)
        {
            return "Doe";
        }

        public string GetClass(int id)
        {
            return "Warrior";
        }
    }
}