using UnityEngine;

namespace Interpreter.Ex2
{
    public class Main : MonoBehaviour
    {
        private void Start()
        {
            string question1 = "2 Gallons to pints";
            AskQuestion(question1);

            string question2 = "4 Gallons to tablespoons";
            AskQuestion(question2);
            
            string question3 = "4 Tablespoons to tablespoons";
            AskQuestion(question3);
        }

        private static void AskQuestion(string question)
        {
            ConversionContext context = new(question);

            Interpreter.ExpressionType toConversion = context.ToConversion;
            Interpreter.ExpressionType fromConversion = context.FromConversion;
            double quantity = context.Quantity;

            Interpreter interpreter = Initialize(fromConversion);

            string result = interpreter.Interpret(toConversion, quantity);
            Debug.Log($"Output: {quantity} {fromConversion} are {result} {toConversion}");
        }

        private static Interpreter Initialize(Interpreter.ExpressionType toConversion)
        {
            Interpreter interpreter = toConversion switch
            {
                Interpreter.ExpressionType.Cups => new GallonsInterpreter(),
                Interpreter.ExpressionType.Pints => new GallonsInterpreter(),
                Interpreter.ExpressionType.Quarts => new GallonsInterpreter(),
                Interpreter.ExpressionType.Gallons => new GallonsInterpreter(),
                Interpreter.ExpressionType.Tablespoons => new TablespoonsInterpreter(),
                _ => new GallonsInterpreter()
            };
            
            return interpreter;
        }
    }
}