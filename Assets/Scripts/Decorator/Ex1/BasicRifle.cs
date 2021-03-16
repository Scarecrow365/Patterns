namespace Decorator.Ex1
{
    public class BasicRifle : IRifle
    {
        private readonly float _basicAccuracy = 50f;

        public float GetAccuracy() => _basicAccuracy;
    }
}