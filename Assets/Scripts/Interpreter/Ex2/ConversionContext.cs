using System.Globalization;
using UnityEngine;

namespace Interpreter.Ex2
{
    public class ConversionContext
    {
        public double Quantity { get; }
        public Interpreter.ExpressionType ToConversion { get; }
        public Interpreter.ExpressionType FromConversion { get; }

        public ConversionContext(string input)
        {
            Debug.Log("Input: " + input);
            string[] partsOfQues = input.Split(new[] { " " }, System.StringSplitOptions.RemoveEmptyEntries);

            if (partsOfQues.Length < 4) 
                return;

            string fromConversation = GetCapitalized(partsOfQues[1]);
            
            FromConversion = CheckOutConversation(GetLowerCase(fromConversation));
            ToConversion = CheckOutConversation(GetLowerCase(partsOfQues[3]));

            double.TryParse(partsOfQues[0], out double result);
            Quantity = result;
        }

        private static string GetCapitalized(string word)
        {
            word = word.ToLower();
            word = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(word);

            if (word.EndsWith("s") == false)
            {
                word += "s";
            }

            return word;
        }

        private Interpreter.ExpressionType CheckOutConversation(string conversation)
        {
            Interpreter.ExpressionType type = conversation switch
            {
                "cups" => Interpreter.ExpressionType.Cups,
                "pints" => Interpreter.ExpressionType.Pints,
                "quarts" => Interpreter.ExpressionType.Quarts,
                "gallons" => Interpreter.ExpressionType.Gallons,
                "tablespoons" => Interpreter.ExpressionType.Tablespoons,
                _ => Interpreter.ExpressionType.Cups
            };

            return type;
        }

        private static string GetLowerCase(string word) => word.ToLower();
    }
}