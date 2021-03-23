using System;
using System.Collections.Generic;
using UnityEngine;

namespace ServiceLocator.Ex1
{
    public class ServiceLocator : MonoBehaviour
    {
        private IDictionary<object, object> _services;

        private void Awake()
        {
            FillRegister();
        }

        private void FillRegister()
        {
            _services = new Dictionary<object, object>
            {
                {typeof(LobbyCoordinator), new LobbyCoordinator()},
                {typeof(CurrencyConverter), new CurrencyConverter()},
                {typeof(LightingCoordinator), new LightingCoordinator()}
            };
        }

        public T GetService<T>()
        {
            try
            {
                return (T) _services[typeof(T)];
            }
            catch (Exception e)
            {
                throw new ApplicationException("Service not found");
            }
        }

    }
}