using UnityEngine;

namespace Iterator.Ex1
{
    public class Main : MonoBehaviour
    {
        private void Start()
        {
            Collection collection = new()
            {
                [0] = new Item("Item 0"),
                [1] = new Item("Item 1"),
                [2] = new Item("Item 2"),
                [3] = new Item("Item 3"),
                [4] = new Item("Item 4"),
                [5] = new Item("Item 5"),
                [6] = new Item("Item 6"),
                [7] = new Item("Item 7"),
                [8] = new Item("Item 8")
            };

            Iterator iterator = collection.Iterator;
            iterator.Step = 2;
            
            Debug.Log("Iterating collection:");

            for (Item item = iterator.First(); !iterator.IsDone; item = iterator.Next())
            {
                Debug.Log(item.Name);
            }
        }
    }
}