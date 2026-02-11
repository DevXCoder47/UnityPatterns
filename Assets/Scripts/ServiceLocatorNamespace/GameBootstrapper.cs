using System;
using UnityEngine;

namespace ServiceLocatorNamespace
{
    public class GameBootstrapper : MonoBehaviour
    {
        private static bool _servicesRegistered = false;
        void Awake()
        {
            try
            {
                if (!_servicesRegistered)
                {
                    ServiceLocator.Register<IMovingService>(new MovingService());
                    ServiceLocator.Register<ITurningService>(new TurningService());
                    _servicesRegistered = true;
                }
            }
            catch(Exception ex) 
            {
                Debug.LogException(ex);
            }
        }
    }
}
