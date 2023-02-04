using System.Collections.Generic;
using UnityEngine;

namespace Interpreter.Ex1
{
    public class Main : MonoBehaviour
    {
        private void Start()
        {
            string roman = "MCMXXVIII";
            Context context = new Context(roman);

            List<Expression> tree = new List<Expression>
            {
                new ThousandExpression(),
                new HundredExpression(),
                new TenExpression(),
                new OneExpression()
            };

            foreach (Expression exp in tree)
            {
                exp.Interpret(context);
                Debug.Log(roman + " = " + context.Output);
            }
        }
    }
}