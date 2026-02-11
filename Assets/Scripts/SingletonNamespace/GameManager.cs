using UnityEngine;

namespace SingletonNamespace
{
    public class GameManager : Singleton<GameManager>
    {
        protected override void Awake()
        {
            base.Awake();
        }

        public void LogHelloWorld()
        {
            Debug.Log("Hello World");
        }
    }
}
