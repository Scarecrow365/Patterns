using System.Collections.Generic;
using UnityEngine;

namespace Strategy.Ex2
{
    internal class QuickSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            list.Sort();
            Debug.Log("-------QuickSorted list------- ");
        }
    }
}