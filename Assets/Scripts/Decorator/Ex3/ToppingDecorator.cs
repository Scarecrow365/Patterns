namespace Assets.Scripts.Decorator.Ex3
{
    public abstract class ToppingDecorator : IPizza
    {
        protected IPizza Pizza;

        protected ToppingDecorator(IPizza pizza)
        {
            Pizza = pizza;
        }

        public virtual string GetDescription()
        {
            return Pizza.GetDescription();
        }

        public virtual double GetCost()
        {
            return Pizza.GetCost();
        }
    }
}