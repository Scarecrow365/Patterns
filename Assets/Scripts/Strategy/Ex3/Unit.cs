namespace Strategy.Ex3
{
    internal abstract class Unit
    {
        protected IFlyStrategy FlyStrategy;

        public string TryToFly() => FlyStrategy.Fly();

        public void SetFlyingAbility(IFlyStrategy newFlyingType) => FlyStrategy = newFlyingType;
    }
}