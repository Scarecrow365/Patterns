namespace AbstractFabric.Example2
{
    public abstract class Ship
    {
        public string Name;
        protected IEngine Engine;
        protected IWeapon Weapon;

        public abstract void MakeShip();

        public void DisplayShip()
        {
        }

        public void Shoot()
        {
        }

        public string ToStringEX()
        {
            return $"The {Name} has a speed of {Engine.ToStringEx()} a firepower of {Weapon.ToStringEx()}";
        }
    }
}