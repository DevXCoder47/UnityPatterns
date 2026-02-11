using UnityEngine;

namespace ServiceLocatorNamespace
{
    public interface ITurningService
    {
        void TurnRight(GameObject player, float speed);
    }
}
