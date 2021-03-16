namespace AbstractFabric.Example2
{
    public class UFOShipBuilding : ShipBuilding
    {
        protected override Ship MakeShip()
        {
            IShipFactory factory = new UFOShipFactory();
            var ship = new UfoShip(factory)
            {
                Name = "UFO"
            };

            return ship;
        }
    }
}