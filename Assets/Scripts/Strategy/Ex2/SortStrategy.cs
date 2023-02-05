using System.Collections.Generic;

namespace Strategy.Ex2
{
    internal abstract class SortStrategy
    {
        public abstract void Sort(List<string> list);
    }
}