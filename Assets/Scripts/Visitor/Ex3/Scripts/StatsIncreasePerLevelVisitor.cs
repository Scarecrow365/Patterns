using System;
using Visitor.Ex3.Scripts.Abstraction;
using Visitor.Ex3.Scripts.Characters;

namespace Visitor.Ex3.Scripts
{
    public class StatsIncreasePerLevelVisitor : ICharacterVisitor<CharacterStats>
    {
        public CharacterStats Visit(Archer archer)
        {
            return archer.Level switch
            {
                2 => new CharacterStats { Agility = 6, Intelligence = 2, Strength = 2 },
                3 => new CharacterStats { Agility = 6, Intelligence = 4, Strength = 5 },
                _ => throw new ArgumentOutOfRangeException("")
            };
        }

        public CharacterStats Visit(Paladin paladin)
        {
            return paladin.Level switch
            {
                2 => new CharacterStats { Agility = 2, Intelligence = 2, Strength = 6 },
                3 => new CharacterStats { Agility = 3, Intelligence = 2, Strength = 10 },
                _ => throw new ArgumentOutOfRangeException("")
            };
        }

        public CharacterStats Visit(Mage mage)
        {
            return mage.Level switch
            {
                2 => new CharacterStats { Agility = 3, Intelligence = 5, Strength = 2 },
                3 => new CharacterStats { Agility = 3, Intelligence = 9, Strength = 3 },
                _ => throw new ArgumentOutOfRangeException("")
            };
        }
    }
}