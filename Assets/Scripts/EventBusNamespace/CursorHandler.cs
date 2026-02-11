using UnityEngine;

namespace EventBusNamespace
{
    public class CursorHandler : MonoBehaviour
    {
        [SerializeField] private Camera _camera;
        [SerializeField] private GameObject _plane;

        void Update()
        {
            if(Input.GetMouseButtonDown(0))
            {
                Ray ray = _camera.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit))
                {
                    if(hit.collider.TryGetComponent<CubeMarker>(out _))
                    {
                        EventBus.Raise(new CubePointedEvent(hit.collider.gameObject));
                        return;
                    }

                    if (hit.collider.gameObject == _plane)
                    {
                        EventBus.Raise(new CursorPointedEvent(hit.point));
                    }
                }
            }
        }
    }
}
