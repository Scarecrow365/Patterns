namespace Interpreter.Ex2
{
    public abstract class Interpreter
    {
        public string Interpret(ExpressionType toConversion, double quantity)
        {
            return toConversion switch
            {
                ExpressionType.Cups => Cups(quantity),
                ExpressionType.Pints => Pints(quantity),
                ExpressionType.Quarts => Quarts(quantity),
                ExpressionType.Gallons => Gallons(quantity),
                ExpressionType.Tablespoons => Tablespoons(quantity),
                _ => Cups(quantity)
            };
        }
        
        protected abstract string Cups(double quantity);
        protected abstract string Pints(double quantity);
        protected abstract string Quarts(double quantity);
        protected abstract string Gallons(double quantity);
        protected abstract string Tablespoons(double quantity);
        
        public enum ExpressionType
        {
            Cups,
            Pints,
            Quarts,
            Gallons,
            Tablespoons
        }
    }
}