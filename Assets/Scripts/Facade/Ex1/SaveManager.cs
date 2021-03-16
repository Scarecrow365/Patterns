using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

namespace Facade.Ex1
{
    public class SaveManager
    {
        private UiManager _uiManager;
        private PlayerData _playerData;
        private ScoreManager _scoreManager;
        private CloudManager _cloudManager;

        public void SaveGame(Player player)
        {
            _uiManager = new UiManager();
            _uiManager.DisplaySaveIcon();

            _playerData = new PlayerData();
            _playerData.health = player.GetHealth();
            _playerData.playerId = player.GetPlayerId();

            _scoreManager = new ScoreManager();
            _playerData.score = _scoreManager.GetScore(_playerData.playerId);

            SerializePlayerData(_playerData, true);
        }

        private void SerializePlayerData(PlayerData data, bool isCloudSave)
        {
            var bf = new BinaryFormatter();
            var file = File.Create(Application.persistentDataPath + "/playerInfo.dat");
            bf.Serialize(file, data);
            file.Close();

            if (isCloudSave)
            {
                _cloudManager = new CloudManager();
                _cloudManager.UploadSaveGame(Application.persistentDataPath + "/playerInfo.dat");
            }
        }
    }
}