using UnityEngine;

namespace ObjectPoolNamespace
{
    public class Rotator : MonoBehaviour
    {
        [SerializeField] private float _speed;

        private float _currentAngle;
        private int _direction = -1;
        private const float MaxAngle = 90f;

        void Update()
        {
            float delta = _speed * Time.deltaTime * _direction;
            _currentAngle += delta;

            if (Mathf.Abs(_currentAngle) >= MaxAngle)
            {
                _currentAngle = Mathf.Clamp(_currentAngle, -MaxAngle, MaxAngle);
                _direction *= -1;
            }

            transform.localRotation = Quaternion.Euler(0f, _currentAngle, 0f);
        }
    }
}
