using Refactoring.Ex1.Fixed_3Strategy.SO.Enemies;

namespace Refactoring.Ex1.Fixed_3Strategy.Factory
{
  public interface IEnemyFactory
  {
    Enemy Create(EnemyConfig config);
  }
}