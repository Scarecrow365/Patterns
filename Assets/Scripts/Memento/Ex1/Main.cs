using UnityEngine;

namespace Memento.Ex1
{
    public class Main : MonoBehaviour
    {
        private void Start()
        {
            SalesProspect prospect = new()
            {
                Name = "Bruce",
                Phone = "(412) 256-6666",
                Budget = 25000.0
            };

            ProspectMemory memory = new()
            {
                Memento = prospect.SaveMemento()
            };

            prospect.Name = "Oliver";
            prospect.Phone = "(310) 209-8888";
            prospect.Budget = 1000000.0;

            prospect.RestoreMemento(memory.Memento);
        }
    }
}