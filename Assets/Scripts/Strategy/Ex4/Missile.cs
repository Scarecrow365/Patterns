namespace Strategy.Ex4
{
    public abstract class Missile
    {
        protected ISeekBehaviour seekBehavior;

        public void ApplySeek()
        {
            seekBehavior.Seek();
        }

        public void SetSeekBehavior(ISeekBehaviour seekType)
        {
            seekBehavior = seekType;
        }
    }
}