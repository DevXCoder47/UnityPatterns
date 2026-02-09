using UnityEngine;

namespace ObjectPoolNamespace {
    public class Gun : MonoBehaviour
    {
        [SerializeField] private Projectile _projectilePrefab;
        [SerializeField] private int _poolSize;

        private ObjectPool<Projectile> _projectilePool;

        void Awake()
        {
            _projectilePool = new ObjectPool<Projectile>(_projectilePrefab, _poolSize);
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Shoot();
            }
        }

        private void Shoot()
        {
            Projectile bullet = _projectilePool.Get();
            bullet.transform.position = transform.position;
            bullet.transform.rotation = transform.rotation;
            bullet.Init(_projectilePool);
        }
    }
}
