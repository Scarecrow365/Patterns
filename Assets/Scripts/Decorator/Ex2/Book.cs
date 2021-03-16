namespace Decorator.Ex2
{
    public class Book : LibraryItem
    {
        private readonly string _author;
        private readonly string _title;

        public Book(string author, string title, int numCopies)
        {
            _author = author;
            _title = title;
            NumCopies = numCopies;
        }

        public override void Display()
        {
            //Debug.Log($"Author: {_author}");
            //Debug.Log($"Title: {_title}");
            //Debug.Log("Copies: {NumCopies}");
        }
    }
}