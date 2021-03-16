namespace AbstractFabric.Example2
{
    public class UfoShip : Ship
    {
        private readonly IShipFactory _factory;

        public UfoShip(IShipFactory factory)
        {
            _factory = factory;
        }

        public override void MakeShip()
        {
            Weapon = _factory.AddWeapon();
            Engine = _factory.AddEngine();
        }
    }
}