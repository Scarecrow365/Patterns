namespace Memento.Ex2
{
    public class Memento
    {
        public Memento(string article)
        {
            Article = article;
        }

        public string Article { get; }
    }
}