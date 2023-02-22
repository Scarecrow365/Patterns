namespace Visitor.Ex3.Scripts
{
    public struct CharacterStats
    {
        public int Agility;
        public int Strength;
        public int Intelligence;

        public static CharacterStats CreateFromOtherWithDeltas(CharacterStats other, CharacterStats deltas) =>
            new(other, deltas);

        public static CharacterStats CreateFromOther(CharacterStats other) => new(other);

        private CharacterStats(CharacterStats source, CharacterStats deltas) : this(source)
        {
            Agility += deltas.Agility;
            Strength += deltas.Strength;
            Intelligence += deltas.Intelligence;
        }

        private CharacterStats(CharacterStats source)
        {
            Agility = source.Agility;
            Strength = source.Strength;
            Intelligence = source.Intelligence;
        }
    }
}