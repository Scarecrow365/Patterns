namespace Command.Ex4
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}