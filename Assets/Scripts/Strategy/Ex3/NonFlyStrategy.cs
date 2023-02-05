namespace Strategy.Ex3
{
    internal class NonFlyStrategy : IFlyStrategy
    {
        public string Fly()
        {
            return "I can't fly";
        }
    }
}