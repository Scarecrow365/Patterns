namespace AbstractFabric.Example2
{
    public class UFOShipFactory : IShipFactory
    {
        public IWeapon AddWeapon()
        {
            return new UfoGun();
        }

        public IEngine AddEngine()
        {
            return new UfoEngine();

        }
    }
}