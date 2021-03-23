namespace Decorator.Ex4
{
    public class Player
    {
        private readonly IStatsProvider _provider;

        public Player(RaceType race)
        {
            _provider = new RaceStats(race);
        }

        public PlayerStats GetData()
        {
            return _provider.GetStats();
        }
    }
}