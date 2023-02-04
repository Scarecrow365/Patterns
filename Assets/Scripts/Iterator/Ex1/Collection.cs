using System.Collections;

namespace Iterator.Ex1
{
    internal class Collection : ICollection
    {
        private readonly ArrayList _items = new ArrayList();

        private Iterator _iterator;

        public Iterator Iterator
        {
            get
            {
                CreateIterator();
                return _iterator;
            }
        }
        
        public void CreateIterator()
        {
            _iterator ??= new Iterator(this);
        }

        public int Count => _items.Count;

        public object this[int index]
        {
            get => _items[index];
            set => _items.Add(value);
        }
    }
}