using UnityEngine;

namespace EventBusNamespace 
{
    public class InstanceHandler : MonoBehaviour
    {
        [SerializeField] private GameObject _prefab;
        [SerializeField] private Material _object1Material;

        void OnEnable()
        {
            EventBus.Subscribe<CursorPointedEvent>(PlacePrefab);
            EventBus.Subscribe<CubePointedEvent>(SetColor);
        }

        void OnDisable()
        {
            EventBus.Unsubscribe<CursorPointedEvent>(PlacePrefab);
            EventBus.Unsubscribe<CubePointedEvent>(SetColor);
        }

        private void PlacePrefab(CursorPointedEvent e)
        {
            Instantiate(_prefab, e.Position, Quaternion.identity);
        }

        private void SetColor(CubePointedEvent e)
        {
            Renderer renderer = e.Cube.GetComponent<Renderer>();          
            renderer.material = _object1Material;
        }
    }
}
