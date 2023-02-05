using UnityEngine;

namespace Memento.Ex2
{
    public class Originator
    {
        private string Article { get; set; }

        public void Set(string article)
        {
            Debug.Log($"From Originator: Current Version of article is: [{Article}]");
            Article = article;
        }

        public Memento StoreInMemento()
        {
            Debug.Log($"From Originator: Saving in Memento: [{Article}]");
            return new Memento(Article);
        }

        public string RestoreFromMemento(Memento memento)
        {
            Article = memento.Article;
            Debug.Log($"From Originator: Previous Article saved in Memento: [{Article}]");
            return Article;
        }
    }
}