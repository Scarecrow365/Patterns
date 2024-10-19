using Refactoring.Ex1.Fixed_2Factory.SO;

namespace Refactoring.Ex1.Fixed_2Factory.Factory
{
  public interface IEnemyFactory
  {
    Enemy Create(EnemyConfig config);
  }
}