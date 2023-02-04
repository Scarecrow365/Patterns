namespace Iterator.Ex1
{
    internal interface IIterator
    {
        Item First();
        Item Next();
        bool IsDone { get; }
        Item CurrentItem { get; }
    }
}