using System.Collections;
using System.Collections.Generic;

namespace Iterator.Ex2
{
    public class SongsOfThe70s : SongsOfTime
    {
        private List<SongInfo> bestSongs;
        
        public sealed override string CollectionName { get; protected set; }

        public SongsOfThe70s()
        {
            bestSongs = new List<SongInfo>();
            CollectionName = "Song 70s: ";
        }

        public override void AddSong(string name, string artist, int year)
        {
            SongInfo song = new(name, artist, year);
            bestSongs.Add(song);
        }
        
        public override IEnumerator GetIterator() => bestSongs.GetEnumerator();
    }
}