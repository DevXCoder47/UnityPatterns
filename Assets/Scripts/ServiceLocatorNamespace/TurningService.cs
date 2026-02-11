using UnityEngine;

namespace ServiceLocatorNamespace {
    public class TurningService : ITurningService
    {
        public void TurnRight(GameObject player, float speed)
        {
            Rigidbody rb = player.GetComponent<Rigidbody>();

            float horizontal = Input.GetAxis("Horizontal");

            float rotationY = horizontal * speed;

            Vector3 angularVelocity = rb.angularVelocity;
            angularVelocity.y = rotationY;
            rb.angularVelocity = angularVelocity;
        }
    }
}
