using UnityEngine;

namespace Decorator.Ex4
{
    public class Main : MonoBehaviour
    {
        private void Start()
        {
            var player = new Player(RaceType.Human);
            ShowInfo(player);

            player = new Player(RaceType.Elf);
            ShowInfo(player);

            player = new Player(RaceType.Orc);
            ShowInfo(player);
        }

        private void ShowInfo(Player player)
        {
            Debug.Log(player.GetData().Stamina);
            Debug.Log(player.GetData().Strength);
            Debug.Log(player.GetData().Agility);
            Debug.Log(player.GetData().Intelligence);
        }
    }
}