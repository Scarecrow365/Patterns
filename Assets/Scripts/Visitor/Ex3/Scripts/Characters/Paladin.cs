using UnityEngine;
using Visitor.Ex3.Scripts.Abstraction;

namespace Visitor.Ex3.Scripts.Characters
{
    public class Paladin : CharacterBase
    {
        private readonly ICharacterVisitor<StatsDistribution> statsDistributionVisitor = new StatsDistributionVisitor();

        private readonly ICharacterVisitor<CharacterStats> statsIncreasePerLevelVisitor =
            new StatsIncreasePerLevelVisitor();

        public override int Level { get; protected set; } = 1;

        public override CharacterStats Stats { get; protected set; } = new()
        {
            Agility = 3,
            Intelligence = 1,
            Strength = 6
        };

        public override void Attack(IDamageable other)
        {
            other.ReceiveDamage(CalculateDamage());
        }

        protected override int CalculateDamage()
        {
            StatsDistribution distribution = statsDistributionVisitor.Visit(this);
            return Mathf.FloorToInt(
                distribution.AgilityPercentage * Stats.Agility +
                distribution.IntelligencePercentage * Stats.Intelligence +
                distribution.StrengthPercentage * Stats.Strength);
        }

        public override void IncreaseLevel()
        {
            Level++;

            CharacterStats deltas = statsIncreasePerLevelVisitor.Visit(this);

            Stats = CharacterStats.CreateFromOtherWithDeltas(Stats, deltas);
        }
    }
}