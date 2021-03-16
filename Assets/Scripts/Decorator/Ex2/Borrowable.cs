using System.Collections.Generic;

namespace Decorator.Ex2
{
    public class Borrowable : Decorator
    {
        protected List<string> borrowers = new List<string>();

        public Borrowable(LibraryItem item) : base(item)
        {
        }

        public void BorrowItem(string name)
        {
            borrowers.Add(name);
            Item.NumCopies++;
        }

        public void ReturnItem(string name)
        {
            borrowers.Remove(name);
            Item.NumCopies--;
        }

        public override void Display()
        {
            base.Display();

            foreach (var borrower in borrowers)
            {
                //smthng
            }
        }
    }
}