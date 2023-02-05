namespace Strategy.Ex3
{
    internal class Bird : Unit
    {
        public Bird()
        {
            FlyStrategy = new FlyStrategy();
        }
    }
}