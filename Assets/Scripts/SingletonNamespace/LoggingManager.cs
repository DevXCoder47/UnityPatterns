using UnityEngine;

namespace SingletonNamespace
{
    public class LoggingManager : MonoBehaviour
    {
        void Start()
        {
            GameManager.Instance.LogHelloWorld();
        }
    }
}
