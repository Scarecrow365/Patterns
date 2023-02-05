namespace Memento.Ex3
{
    internal class Originator
    {
        public string State { get; set; }

        public Memento CreateMemento() => new(State);

        public void RestoreMemento(Memento memento) => State = memento.State;
    }
}