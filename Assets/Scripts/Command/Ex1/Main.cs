using System.Collections.Generic;

namespace Command.Ex1
{
    public class Main
    {
        private Calculator _calculator = new Calculator();
        private List<Command> _commands = new List<Command>();
        private int _current;

        public void Redo(int levels)
        {
            for (int i = 0; i < levels; i++)
            {
                if (_current < _commands.Count - 1)
                {
                    var command = _commands[_current++];
                    command.Execute();
                }
            }
        }

        public void Undo(int levels)
        {
            for (int i = 0; i < levels; i++)
            {
                if (_current > 0)
                {
                    var command = _commands[--_current];
                    command.UnExecute();
                }
            }
        }

        public void Compute(char symbolOperator, int operand)
        {
            var command = new CalculatorCommand(symbolOperator, operand, _calculator);
            command.Execute();

            _commands.Add(command);
            _current++;
        }
    }
}