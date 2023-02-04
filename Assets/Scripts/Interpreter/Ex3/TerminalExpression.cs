using UnityEngine;

namespace Interpreter.Ex3
{
    internal class TerminalExpression : AbstractExpression
    {
        public override void Interpret(Context context)
        {
            Debug.Log("Called Terminal.Interpret()");
        }
    }
}