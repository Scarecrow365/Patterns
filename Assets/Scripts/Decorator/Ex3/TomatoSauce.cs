namespace Assets.Scripts.Decorator.Ex3
{
    public class TomatoSauce : ToppingDecorator
    {
        public TomatoSauce(IPizza pizza) : base(pizza)
        {
        }

        public override string GetDescription()
        {
            return base.GetDescription() + ", tomato sauce";
        }

        public override double GetCost()
        {
            return base.GetCost() + 0.3;
        }
    }
}