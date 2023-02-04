namespace Interpreter.Ex2
{
    public class GallonsInterpreter : Interpreter
    {
        protected override string Gallons(double quantity) => quantity.ToString();
        protected override string Quarts(double quantity) => (quantity * 4).ToString();
        protected override string Pints(double quantity) => (quantity * 8).ToString();
        protected override string Cups(double quantity) => (quantity * 16).ToString();
        protected override string Tablespoons(double quantity) => (quantity * 256).ToString();
    }
}