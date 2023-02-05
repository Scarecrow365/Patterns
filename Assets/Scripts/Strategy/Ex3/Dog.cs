namespace Strategy.Ex3
{
    internal class Dog : Unit
    {
        public Dog()
        {
            FlyStrategy = new NonFlyStrategy();
        }
    }
}