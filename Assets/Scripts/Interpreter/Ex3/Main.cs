using System.Collections;
using UnityEngine;

namespace Interpreter.Ex3
{
    public class Main : MonoBehaviour
    {
        private void Start()
        {
            Context context = new();

            ArrayList list = new()
            {
                new TerminalExpression(),
                new NonTerminalExpression(),
                new TerminalExpression(),
                new NonTerminalExpression()
            };

            foreach (AbstractExpression exp in list)
            {
                exp.Interpret(context);
            }
        }
    }
}