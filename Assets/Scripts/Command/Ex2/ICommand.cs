namespace Command.Ex2
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}