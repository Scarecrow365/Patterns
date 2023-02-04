namespace Interpreter.Ex1
{
    internal class Context
    {
        public Context(string input) => Input = input;
        public string Input { get; set; }
        public int Output { get; set; }
    }
}