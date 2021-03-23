namespace Decorator.Ex4
{
    public abstract class StatsDecorator : IStatsProvider
    {
        protected IStatsProvider _wrappedEntity;

        protected StatsDecorator(IStatsProvider wrappedEntity)
        {
            _wrappedEntity = wrappedEntity;
        }

        public PlayerStats GetStats()
        {
            return GetStatsInternal();
        }

        protected abstract PlayerStats GetStatsInternal();
    }
}