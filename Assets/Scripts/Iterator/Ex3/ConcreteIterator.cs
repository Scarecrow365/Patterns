namespace Iterator.Ex3
{
    internal class ConcreteIterator : Iterator
    {
        private readonly ConcreteAggregate _aggregate;
        private int _current;

        public ConcreteIterator(ConcreteAggregate aggregate)
        {
            _aggregate = aggregate;
        }
        
        public override object Next()
        {
            object ret = null;
            if (_current < _aggregate.Count - 1)
            {
                ret = _aggregate[++_current];
            }

            return ret;
        }

        public override object First() => _aggregate[0];
        public override object CurrentItem() => _aggregate[_current];
        public override bool IsDone() => _current >= _aggregate.Count;
    }
}