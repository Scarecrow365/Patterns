using UnityEngine;

namespace Iterator.Ex3
{
    public class Main : MonoBehaviour
    {
        private void Start ( )
        {
            ConcreteAggregate aggregate = new()
            {
                [0] = "Item A",
                [1] = "Item B",
                [2] = "Item C",
                [3] = "Item D"
            };

            Iterator iterator = aggregate.CreateIterator();

            Debug.Log("Iterating over collection:");

            object item = iterator.First();
            while (item != null)
            {
                Debug.Log(item);
                item = iterator.Next();
            }
        }
    }
}