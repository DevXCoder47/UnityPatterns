using UnityEngine;

namespace ServiceLocatorNamespace
{
    public class MovingService : IMovingService
    {
        public void MoveForward(GameObject player, float speed)
        {
            Rigidbody rb = player.GetComponent<Rigidbody>();

            float vertical = Input.GetAxis("Vertical");

            Vector3 direction = player.transform.forward * vertical;

            Vector3 velocity = direction * speed;
            velocity.y = rb.linearVelocity.y;

            rb.linearVelocity = velocity;
        }

        public void StopMovement(GameObject player)
        {
            Rigidbody rb = player.GetComponent<Rigidbody>();

            rb.linearVelocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }
    }
}
