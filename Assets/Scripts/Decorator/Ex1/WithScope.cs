namespace Decorator.Ex1
{
    public class WithScope : RifleDecorator
    {
        private readonly float _scopeAccuracy = 20;

        public WithScope(IRifle rifle) : base(rifle) { }

        public override float GetAccuracy()
        {
            return base.GetAccuracy() + _scopeAccuracy;
        }
    }
}