namespace Decorator.Ex1
{
    public class WithStabilizer : RifleDecorator
    {
        private float _accuracy = 10;

        public WithStabilizer(IRifle decoratedRifle) : base(decoratedRifle)
        {
        }

        public override float GetAccuracy()
        {
            return base.GetAccuracy() + _accuracy;
        }
    }
}