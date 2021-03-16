namespace Decorator.Ex1
{
    public class RifleDecorator : IRifle
    {
        protected IRifle DecoratedRifle;

        public virtual float GetAccuracy() => DecoratedRifle.GetAccuracy();

        public RifleDecorator(IRifle decoratedRifle)
        {
            DecoratedRifle = decoratedRifle;
        }
    }
}