using UnityEngine;

namespace EventBusNamespace
{
    public struct CursorPointedEvent
    {
        public Vector3 Position;

        public CursorPointedEvent(Vector3 position)
        {
            Position = position;
        }
    }
}
