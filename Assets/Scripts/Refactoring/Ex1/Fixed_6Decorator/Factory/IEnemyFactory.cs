using Refactoring.Ex1.Fixed_6Decorator.SO.Enemies;

namespace Refactoring.Ex1.Fixed_6Decorator.Factory
{
  public interface IEnemyFactory
  {
    Enemy Create(EnemyConfig config);
  }
}