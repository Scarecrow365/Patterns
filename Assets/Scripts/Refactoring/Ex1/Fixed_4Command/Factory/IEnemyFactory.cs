using Refactoring.Ex1.Fixed_4Command.SO.Enemies;

namespace Refactoring.Ex1.Fixed_4Command.Factory
{
  public interface IEnemyFactory
  {
    Enemy Create(EnemyConfig config);
  }
}