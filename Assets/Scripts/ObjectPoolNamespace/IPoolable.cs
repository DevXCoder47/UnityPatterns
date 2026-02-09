using UnityEngine;

namespace ObjectPoolNamespace
{
    public interface IPoolable
    {
        void OnSpawn();
        void OnDespawn();
    }
}
