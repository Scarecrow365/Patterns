namespace AbstractFabric.Example2
{
    public abstract class ShipBuilding
    {
        protected abstract Ship MakeShip();

        public Ship OrderShip()
        {
            var ship = MakeShip();
            return ship;
        }
    }
}