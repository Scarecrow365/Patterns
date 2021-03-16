using UnityEngine;

namespace Adapter.Ex1
{
    public class Main : MonoBehaviour
    {
        private void Start()
        {
            var player = ScriptableObject.CreateInstance<Adapter>();

            var FirstName = player.GetFirstName(8);
            var LastName = player.GetLastName(8);
            var playerClass = player.GetClass(8);
            var fullName = player.GetFullName(8);

            Debug.Log(FirstName);
            Debug.Log(LastName);
            Debug.Log(fullName);

            Debug.Log(playerClass);
        }
    }
}
