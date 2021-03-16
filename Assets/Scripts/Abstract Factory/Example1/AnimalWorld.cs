namespace Abstract_Fabric
{
    public class AnimalWorld
    {
        private readonly Hunter _hunter;
        private readonly Victim _victim;

        public AnimalWorld(CountryFactory factory)
        {
            _hunter = factory.CreateHunter();
            _victim = factory.CreateVictim();
        }

        public void RunFoodChain()
        {
            _hunter.Eat(_victim);
        }
    }
}