namespace Assets.Scripts.Decorator.Ex3
{
    public class PlainPizza : IPizza
    {
        public string GetDescription()
        {
            return "Thin dough";
        }

        public double GetCost()
        {
            return 5;
        }
    }
}