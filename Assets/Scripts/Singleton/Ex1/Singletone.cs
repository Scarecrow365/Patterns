using UnityEngine;

namespace Singleton.Ex1
{
    public class Singleton : MonoBehaviour
    {
        private static Singleton instance;

        public static Singleton Instance
        {
            get
            {
                if (instance == null) SetupInstance();
                return instance;
            }
        }

        private void Awake()
        {
            if (instance == null)
            {
                instance = this;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }

        private static void SetupInstance()
        {
            instance = FindObjectOfType<Singleton>();

            if (instance != null) return;

            GameObject gameObj = new() {name = "Singleton"};
            instance = gameObj.AddComponent<Singleton>();
            DontDestroyOnLoad(gameObj);
        }
    }
}