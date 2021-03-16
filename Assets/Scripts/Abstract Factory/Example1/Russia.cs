namespace Abstract_Fabric
{
    public class Russia : CountryFactory
    {
        public override Hunter CreateHunter()
        {
            return new Wolf();
        }

        public override Victim CreateVictim()
        {
            return new Bunny();
        }
    }
}