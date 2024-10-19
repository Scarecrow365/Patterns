﻿using System.Collections.Generic;
using Refactoring.Ex1.Fixed_5Builder.Factory;
using Refactoring.Ex1.Fixed_5Builder.SO.Enemies;
using Refactoring.Ex1.Fixed_5Builder.SO.Placements;
using UnityEngine;

namespace Refactoring.Ex1.Fixed_5Builder
{
  public class EnemySpawner : MonoBehaviour
  {
    public int maxEnemies = 10;
    public PlacementStrategy PlacementStrategy;
    public List<EnemyConfig> EnemyConfigs;

    private readonly IEnemyFactory enemyFactory = new EnemyFactory();

    private void Start()
    {
      SpawnEnemies();
    }

    private void SpawnEnemies()
    {
      for (var i = 0; i < maxEnemies; i++)
      {
        Enemy enemy = enemyFactory.Create(EnemyConfigs[i % EnemyConfigs.Count]);
        enemy.transform.position = PlacementStrategy.SetPosition(Vector3.zero);
      }
    }
  }
}