using System;
using System.Collections.Generic;

namespace EventBusNamespace
{
    public static class EventBus
    {
        private static readonly Dictionary<Type, Delegate> _events = new();

        public static void Subscribe<T> (Action<T> handler)
        {
            var type = typeof(T);

            if (_events.TryGetValue(type, out var existing))
                _events[type] = Delegate.Combine(existing, handler);
            else
                _events[type] = handler;
        }

        public static void Unsubscribe<T>(Action<T> handler)
        {
            var type = typeof(T);

            if (!_events.TryGetValue(type, out var existing))
                return;

            var current = Delegate.Remove(existing, handler);

            if (current == null)
                _events.Remove(type);
            else
                _events[type] = current;
        }

        public static void Raise<T> (T eventData)
        {
            if (_events.TryGetValue(typeof(T), out var existing))
                ((Action<T>)existing)?.Invoke(eventData);
        }
    }
}
