using System;
using UnityEditor;

namespace Command.Ex1
{
    public class CalculatorCommand : Command
    {
        private char _symbolOperator;
        private int _operand;
        private Calculator _calculator;

        public CalculatorCommand(char symbolOperator, int operand, Calculator calculator)
        {
            _symbolOperator = symbolOperator;
            _operand = operand;
            _calculator = calculator;
        }

        public char Operator
        {
            set => _symbolOperator = value;
        }

        public int Operand
        {
            set => _operand = value;
        }

        public override void Execute()
        {
            _calculator.Operation(_symbolOperator, _operand);
        }

        public override void UnExecute()
        {
            _calculator.Operation(Undo(_symbolOperator), _operand);
        }

        private char Undo(char symbol)
        {
            return symbol switch
            {
                '+' => '-',
                '-' => '+',
                '*' => '/',
                '/' => '*',
                _ => throw new ArgumentException("symbol")
            };
        }
    }
}