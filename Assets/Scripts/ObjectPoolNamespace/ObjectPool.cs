using System.Collections.Generic;
using UnityEngine;

namespace ObjectPoolNamespace
{
    public class ObjectPool<T> where T : Component, IPoolable
    {
        private readonly T _prefab;
        private readonly Transform _parent;
        private readonly Queue<T> _pool = new();

        public ObjectPool(T prefab, int initialSize, Transform parent = null)
        {
            _prefab = prefab;
            _parent = parent;

            for (int i = 0; i < initialSize; i++)
            {
                CreateNewObject();
            }
        }

        private T CreateNewObject()
        {
            T obj = Object.Instantiate(_prefab, _parent);
            obj.gameObject.SetActive(false);
            _pool.Enqueue(obj);
            return obj;
        }

        public T Get()
        {
            T obj = _pool.Count > 0 ? _pool.Dequeue() : CreateNewObject();
            obj.gameObject.SetActive(true);
            obj.OnSpawn();
            return obj;
        }

        public void Release(T obj)
        {
            obj.OnDespawn();
            obj.gameObject.SetActive(false);
            _pool.Enqueue(obj);
        }
    }
}
