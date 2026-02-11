using UnityEngine;

namespace ServiceLocatorNamespace
{
    public interface IMovingService
    {
        void MoveForward(GameObject player, float speed);
        void StopMovement(GameObject player);
    }
}
