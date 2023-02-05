using System.Collections.Generic;
using UnityEngine;

namespace Strategy.Ex2
{
    internal class SortedList
    {
        private readonly List<string> _list = new List<string>();
        private SortStrategy currentStrategy;

        public void SetSortStrategy(SortStrategy sortStrategy)
        {
            currentStrategy = sortStrategy;
        }

        public void Add(string name) => _list.Add(name);

        public void Sort()
        {
            currentStrategy.Sort(_list);
            
            foreach (string name in _list)
            {
                Debug.Log(" " + name);
            }
        }
    }
}