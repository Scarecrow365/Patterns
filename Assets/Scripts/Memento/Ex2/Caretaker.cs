using System.Collections.Generic;

namespace Memento.Ex2
{
    public class Caretaker
    {
        private readonly List<Memento> savedArticles = new();

        public Memento GetLast() => savedArticles[^1];

        public Memento Get(int index) => savedArticles[index];

        public int GetCountOfSavedArticles() => savedArticles.Count;

        public void Add(Memento memento) => savedArticles.Add(memento);
    }
}