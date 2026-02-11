using System;
using System.Collections.Generic;

namespace ServiceLocatorNamespace
{
    public static class ServiceLocator
    {
        private static readonly Dictionary<Type, object> _services = new();

        public static void Register<T>(T service)
        {
            var type = typeof(T);

            if (_services.ContainsKey(type))
                throw new Exception($"Service {type} already registered");

            _services[type] = service;
        }

        public static T Get<T>()
        {
            var type = typeof(T);

            if (!_services.TryGetValue(type, out var service))
                throw new Exception($"Service {type} not found");

            return (T)service;
        }

        public static void Clear()
        {
            _services.Clear();
        }
    }
}
