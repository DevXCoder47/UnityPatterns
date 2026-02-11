using UnityEngine;

namespace EventBusNamespace
{
    public struct CubePointedEvent
    {
        public GameObject Cube;

        public CubePointedEvent(GameObject cube)
        {
            Cube = cube;
        }
    }
}
