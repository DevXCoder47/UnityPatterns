using UnityEngine;
using UnityEngine.SceneManagement;

namespace Management
{
    public class MenuManager : MonoBehaviour
    {
        public void OnObjectPoolButtonClick()
        {
            SceneManager.LoadScene("ObjectPoolScene");
        }

        public void OnEventBusButtonClick()
        {
            SceneManager.LoadScene("EventBusScene");
        }

        public void OnStateMachineButtonClick()
        {
            SceneManager.LoadScene("StateMachineScene");
        }

        public void OnServiceLocatorButtonClick()
        {
            SceneManager.LoadScene("ServiceLocatorScene");
        }

        public void OnSingletonButtonClick()
        {
            SceneManager.LoadScene("SingletonScene");
        }

        public void OnExitButtonClick()
        {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
        }
    }
}
