using UnityEngine;

namespace Memento.Ex3
{
    public class Main : MonoBehaviour
    {
        private void Start ( )
        {
            Originator originator = new();
            originator.State = "On";

            Caretaker caretaker = new();
            caretaker.Memento = originator.CreateMemento();
            Debug.Log($"Save current state = {originator.State}");

            originator.State = "Off";
            Debug.Log($"State changed = {originator.State}");

            originator.RestoreMemento(caretaker.Memento);
            Debug.Log($"Restoring state = {originator.State}");
        }
    }
}
