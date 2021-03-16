using System;
using UnityEngine;

namespace Prototype.Ex1
{
    public class Main : MonoBehaviour
    {
        public Drone DronePrototype;
        public Sniper SniperPrototype;
        public Spawner Spawner;
        
        private int _incrementorDrone;
        private int _incrementorSniper;

        private void Start()
        {
            CreateDrone();
            CreateSniper();
        }

        private void CreateDrone()
        {
            var enemy = Spawner.SpawnEnemy(DronePrototype);
            enemy.name = $"Drone_clone_{_incrementorDrone}";
        }

        private void CreateSniper()
        {
            var enemy = Spawner.SpawnEnemy(SniperPrototype);
            enemy.name = $"Drone_clone_{_incrementorDrone}";
        }
    }
}