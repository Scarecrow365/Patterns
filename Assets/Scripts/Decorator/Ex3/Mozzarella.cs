namespace Assets.Scripts.Decorator.Ex3
{
    public class Mozzarella : ToppingDecorator
    {
        public Mozzarella(IPizza pizza) : base(pizza)
        {
        }

        public override string GetDescription()
        {
            return base.GetDescription() + ", mozzarella";
        }

        public override double GetCost()
        {
            return base.GetCost() + 0.5f;
        }
    }
}