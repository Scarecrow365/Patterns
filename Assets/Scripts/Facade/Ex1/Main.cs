using System;
using UnityEngine;

namespace Facade.Ex1
{
    public class Main : MonoBehaviour
    {
        private Player _player;
        private SaveManager _saveManager;

        private void Start()
        {
            _player = new Player();
            _saveManager = new SaveManager();

            _saveManager.SaveGame(_player);
        }
    }
}