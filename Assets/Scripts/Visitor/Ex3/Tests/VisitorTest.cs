using NUnit.Framework;
using UnityEngine;
using Visitor.Ex3.Scripts;
using Visitor.Ex3.Scripts.Characters;

namespace Visitor.Ex3.Tests
{
    public class VisitorTest
    {
        [Test]
        public void Characters_Level1_DealDamage()
        {
            // Arrange
            Archer archer = new();
            Enemy archerEnemy = new();
            int archerEnemyHealthBeforeDamage = archerEnemy.Health;

            Paladin paladin = new();
            Enemy paladinEnemy = new();
            int paladinEnemyEnemyHealthBeforeDamage = paladinEnemy.Health;

            Mage mage = new();
            Enemy mageEnemy = new();
            int mageEnemyEnemyHealthBeforeDamage = mageEnemy.Health;

            // Act
            mage.Attack(mageEnemy);
            archer.Attack(archerEnemy);
            paladin.Attack(paladinEnemy);

            // Assert
            Assert.AreNotEqual(archerEnemyHealthBeforeDamage, archerEnemy.Health);
            Debug.Log($"ArcherEnemy health before: {archerEnemyHealthBeforeDamage}, after damage received: {archerEnemy.Health}");

            Assert.AreNotEqual(paladinEnemyEnemyHealthBeforeDamage, paladinEnemy.Health);
            Debug.Log($"PaladinEnemy health before: {paladinEnemyEnemyHealthBeforeDamage}, after damage received: {paladinEnemy.Health}");

            Assert.AreNotEqual(mageEnemyEnemyHealthBeforeDamage, mageEnemy.Health);
            Debug.Log($"MageEnemy health before: {mageEnemyEnemyHealthBeforeDamage}, after damage received: {mageEnemy.Health}");
        }

        [Test]
        public void Characters_Level2_DealDamage()
        {
            // Arrange
            Archer archer = new();
            Enemy archerEnemy = new();
            int archerEnemyHealthBeforeDamage = archerEnemy.Health;

            Paladin paladin = new();
            Enemy paladinEnemy = new();
            int paladinEnemyEnemyHealthBeforeDamage = paladinEnemy.Health;

            Mage mage = new();
            Enemy mageEnemy = new();
            int mageEnemyEnemyHealthBeforeDamage = mageEnemy.Health;

            // Act
            archer.IncreaseLevel();
            archer.Attack(archerEnemy);

            paladin.IncreaseLevel();
            paladin.Attack(paladinEnemy);

            mage.IncreaseLevel();
            mage.Attack(mageEnemy);

            // Assert
            Assert.AreNotEqual(archerEnemyHealthBeforeDamage, archerEnemy.Health);
            Debug.Log($"ArcherEnemy health before: {archerEnemyHealthBeforeDamage}, after damage received: {archerEnemy.Health}");

            Assert.AreNotEqual(paladinEnemyEnemyHealthBeforeDamage, paladinEnemy.Health);
            Debug.Log($"PaladinEnemy health before: {paladinEnemyEnemyHealthBeforeDamage}, after damage received: {paladinEnemy.Health}");

            Assert.AreNotEqual(mageEnemyEnemyHealthBeforeDamage, mageEnemy.Health);
            Debug.Log($"MageEnemy health before: {mageEnemyEnemyHealthBeforeDamage}, after damage received: {mageEnemy.Health}");
        }
    }
}
