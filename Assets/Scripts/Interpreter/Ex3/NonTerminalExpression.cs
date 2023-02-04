using UnityEngine;

namespace Interpreter.Ex3
{
    internal class NonTerminalExpression : AbstractExpression
    {
        public override void Interpret(Context context)
        {
            Debug.Log("Called NonTerminal.Interpret()");
        }
    }
}