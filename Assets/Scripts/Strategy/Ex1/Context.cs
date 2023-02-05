namespace Strategy.Ex1
{
    internal class Context
    {
        private readonly Strategy currentStrategy;

        public Context(Strategy strategy)
        {
            currentStrategy = strategy;
        }

        public void ContextInterface()
        {
            currentStrategy.AlgorithmInterface();
        }
    }
}