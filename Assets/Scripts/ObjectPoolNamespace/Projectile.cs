using UnityEngine;

namespace ObjectPoolNamespace
{
    public class Projectile : MonoBehaviour, IPoolable
    {
        [SerializeField] private float _speed;
        [SerializeField] private float _lifeTime;

        private ObjectPool<Projectile> _pool;
        private float _timer;

        public void Init(ObjectPool<Projectile> pool)
        {
            _pool = pool;
            _timer = _lifeTime;
        }

        public void OnDespawn()
        {
            
        }

        public void OnSpawn()
        {
            
        }

        private void Update()
        {
            transform.Translate(Vector3.forward * _speed * Time.deltaTime);

            _timer -= Time.deltaTime;
            if (_timer <= 0f)
            {
                _pool.Release(this);
            }
        }

        private void OnCollisionEnter(Collision collision)
        {
            _pool.Release(this);
        }
    }
}
