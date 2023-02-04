namespace Iterator.Ex1
{
    internal class Iterator : IIterator
    {
        private int _current;
        private readonly Collection _collection;
        public int Step { get; set; } = 1;

        public Iterator(Collection collection)
        {
            _collection = collection;
        }

        public Item First()
        {
            _current = 0;
            return _collection[_current] as Item;
        }

        public Item Next()
        {
            _current += Step;
            return !IsDone ? _collection[_current] as Item : null;
        }
        
        public Item CurrentItem => _collection[_current] as Item;

        public bool IsDone => _current >= _collection.Count;
    }
}