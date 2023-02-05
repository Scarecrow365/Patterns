using UnityEngine;

namespace Memento.Ex2
{
    public class Main : MonoBehaviour
    {
        private readonly Caretaker caretaker = new();

        private readonly Originator originator = new();
        private int currentArticle;

        private int savedFiles;

        private void Start()
        {
            Save("Tex1: Hello World, this is text example 1");
            Save("Text2: Ok here comes example number 2.");
            Save("Text3: And example number 3. Just testing.");
            Save("Text4: ....");

            Debug.Log("Pressing Undo");
            Undo();
            Debug.Log("Pressing Undo");
            Undo();
            Debug.Log("Pressing Undo");
            Undo();
            Debug.Log("Pressing Redo");
            Redo();
            Debug.Log("Pressing Last Save");
            LoadLastSave();
        }

        public void Save(string text)
        {
            originator.Set(text);
            caretaker.Add(originator.StoreInMemento());
            savedFiles = caretaker.GetCountOfSavedArticles();
            currentArticle = savedFiles;
        }

        public string Undo()
        {
            if (currentArticle > 0)
                currentArticle -= 1;

            Memento prev = caretaker.Get(currentArticle);
            return originator.RestoreFromMemento(prev);
        }

        public string Redo()
        {
            if (currentArticle < savedFiles)
                currentArticle += 1;

            Memento next = caretaker.Get(currentArticle);
            return originator.RestoreFromMemento(next);
        }

        public string LoadLastSave()
        {
            Memento lastSave = caretaker.GetLast();
            return originator.RestoreFromMemento(lastSave);
        }
    }
}