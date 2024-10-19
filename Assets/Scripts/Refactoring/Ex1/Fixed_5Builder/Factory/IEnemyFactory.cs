using Refactoring.Ex1.Fixed_5Builder.SO.Enemies;

namespace Refactoring.Ex1.Fixed_5Builder.Factory
{
  public interface IEnemyFactory
  {
    Enemy Create(EnemyConfig config);
  }
}