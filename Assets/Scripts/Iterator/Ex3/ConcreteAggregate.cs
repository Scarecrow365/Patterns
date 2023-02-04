using System.Collections;

namespace Iterator.Ex3
{
    internal class ConcreteAggregate : Aggregate
    {
        private readonly ArrayList _items = new();

        public override Iterator CreateIterator() => new ConcreteIterator(this);

        public int Count => _items.Count;

        public object this[int index]
        {
            get => _items[index];
            set => _items.Insert(index, value);
        }
    }
}