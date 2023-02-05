using UnityEngine;

namespace Memento.Ex1
{
    internal class SalesProspect
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public double Budget { get; set; }

        public Memento SaveMemento()
        {
            Debug.Log($"Saving state -- {Name} {Phone} {Budget}");
            return new Memento(Name, Phone, Budget);
        }

        public void RestoreMemento(Memento memento)
        {
            Debug.Log($"Restoring state -- {Name} {Phone} {Budget}");

            Name = memento.Name;
            Phone = memento.Phone;
            Budget = memento.Budget;

            Debug.Log($"Restored state -- {Name} {Phone} {Budget}");
        }
    }
}