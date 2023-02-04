using System.Collections;

namespace Iterator.Ex2
{
    public abstract class SongsOfTime : ISongIterator
    {
        public abstract string CollectionName { get; protected set; }
        public abstract void AddSong(string name, string artist, int year);

        public virtual IEnumerator GetIterator()
        {
            yield return null;
        }
    }
}