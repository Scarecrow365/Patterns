using System.Collections.Generic;
using UnityEngine;

namespace Strategy.Ex2
{
    internal class ShellSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            Debug.Log("-------ShellSorted list------- ");
        }
    }
}