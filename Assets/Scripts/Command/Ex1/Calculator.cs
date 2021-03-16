namespace Command.Ex1
{
    public class Calculator
    {
        private int _current;

        public void Operation(char symbolOperator, int operand)
        {
            switch (symbolOperator)
            {
                case '+': _current += operand; break;
                case '-': _current -= operand; break;
                case '*': _current *= operand; break;
                case '/': _current /= operand; break;
            }
        }
    }
}