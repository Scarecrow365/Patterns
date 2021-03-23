namespace Decorator.Ex4
{
    public class RaceStats : IStatsProvider
    {
        private readonly RaceType _raceType;

        public RaceStats(RaceType raceType)
        {
            _raceType = raceType;
        }

        public PlayerStats GetStats()
        {
            switch (_raceType)
            {
                case RaceType.Orc:
                    return new PlayerStats()
                    {
                        Strength = 8,
                        Agility = 3,
                        Intelligence = 2,
                        Stamina = 8
                    };
                case RaceType.Elf:
                    return new PlayerStats()
                    {
                        Strength = 3,
                        Agility = 8,
                        Intelligence = 7,
                        Stamina = 5
                    };
                default:
                    return new PlayerStats()
                    {
                        Strength = 5,
                        Agility = 5,
                        Intelligence = 5,
                        Stamina = 5
                    };
            }
        }
    }
}