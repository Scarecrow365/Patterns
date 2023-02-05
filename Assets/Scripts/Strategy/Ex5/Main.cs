using Strategy.Ex5.Spells;
using Strategy.Ex5.Weapon;
using UnityEngine;

namespace Strategy.Ex5
{
    public class Main : MonoBehaviour
    {
        private void Start()
        {
            Unit player = InitPlayer();
            Unit Enemy = InitEnemy();

            player.Target = Enemy;
            Enemy.Target = player;
            
            player.AttackRightHand();
            Enemy.AttackLeftHand();

            player.RightHand = new Dagger();
            player.AttackRightHand();
            player.AttackLeftHand();
            
            Enemy.AttackRightHand();
            Enemy.AttackLeftHand();
        }

        private static Unit InitPlayer()
        {
            Unit player = new()
            {
                Name = "Player",
                Health = 100,
                Mana = 10,
                LeftHand = new FireAttack(),
                RightHand = new Sword()
            };
            return player;
        }

        private static Unit InitEnemy()
        {
            Unit Enemy = new()
            {
                Name = "Enemy",
                Health = 50,
                Mana = 50,
                LeftHand = new FireAttack(),
                RightHand = new PoisonAttack()
            };
            return Enemy;
        }
    }
}