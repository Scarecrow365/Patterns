using System.Collections.Generic;
using UnityEngine;

namespace Strategy.Ex2
{
    internal class MergeSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            Debug.Log("-------MergeSorted list------- ");
        }
    }
}