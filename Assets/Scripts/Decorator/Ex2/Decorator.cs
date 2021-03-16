namespace Decorator.Ex2
{
    public abstract class Decorator : LibraryItem
    {
        protected LibraryItem Item;

        public Decorator(LibraryItem item)
        {
            Item = item;
        }

        public override void Display()
        {
            Item.Display();
        }
    }
}