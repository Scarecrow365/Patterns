namespace Decorator.Ex4
{
    public struct PlayerStats
    {
        public float Strength { get; set; }
        public float Agility { get; set; }
        public float Intelligence { get; set; }
        public float Stamina { get; set; }

        public PlayerStats Add(PlayerStats basePlayerStats, PlayerStats newPlayerStats)
        {
            return new PlayerStats()
            {
                Strength = basePlayerStats.Strength + newPlayerStats.Strength,
                Agility = basePlayerStats.Agility + newPlayerStats.Agility,
                Intelligence = basePlayerStats.Intelligence + newPlayerStats.Intelligence,
                Stamina = basePlayerStats.Stamina + newPlayerStats.Stamina
            };
        }

        public PlayerStats MultipleStats(PlayerStats basePlayerStats, float value)
        {
            return new PlayerStats()
            {
                Strength = basePlayerStats.Strength * value,
                Agility = basePlayerStats.Agility * value,
                Intelligence = basePlayerStats.Intelligence * value,
                Stamina = basePlayerStats.Stamina * value
            };
        }
    }
}
