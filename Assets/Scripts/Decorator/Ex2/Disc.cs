namespace Decorator.Ex2
{
    public class Disc : LibraryItem
    {
        private readonly string _author;
        private readonly string _title;
        private readonly int _playTime;

        public Disc(string author, string title, int playTime, int numCopies)
        {
            _author = author;
            _title = title;
            _playTime = playTime;
            NumCopies = numCopies;
        }

        public override void Display()
        {
            //Debug.Log($"Author: {_author}");
            //Debug.Log($"Title: {_title}");
            //Debug.Log($"Playtime: {_playTime}");
            //Debug.Log("Copies: {NumCopies}");
        }
    }
}