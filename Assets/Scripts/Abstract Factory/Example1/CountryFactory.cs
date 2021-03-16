namespace Abstract_Fabric
{
    public abstract class CountryFactory
    {
        public abstract Hunter CreateHunter();
        public abstract Victim CreateVictim();
    }
}