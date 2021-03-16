using UnityEngine;

namespace Pool.Ex1
{
    public class Main : MonoBehaviour
    {
        public ObjectPool ObjectPool;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.G))
            {
                var walker = ObjectPool.PullObject("Zombie");
                walker.transform.Translate(Vector3.forward * Random.Range(-5.0f, 5.0f));
                walker.transform.Translate(Vector3.right * Random.Range(-5.0f, 5.0f));
            }

            if (Input.GetKeyDown(KeyCode.P))
            {
                object[] objs = GameObject.FindObjectsOfType(typeof(GameObject));

                foreach (var o in objs)
                {
                    var obj = (GameObject)o;

                    if (obj.gameObject.GetComponent<Zombie>() != null)
                    {
                        ObjectPool.PoolObject(obj);
                    }
                }
            }
        }
    }
}
