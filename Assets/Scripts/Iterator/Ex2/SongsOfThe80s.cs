using System;
using System.Collections;
using System.Collections.Generic;

namespace Iterator.Ex2
{
    public class SongsOfThe80s : SongsOfTime
    {
        private SongInfo[] bestSongs;

        public sealed override string CollectionName { get; protected set; }

        public SongsOfThe80s()
        {
            bestSongs = Array.Empty<SongInfo>();
            CollectionName = "Song 80s: ";
        }

        public override void AddSong(string name, string artist, int year)
        {
            SongInfo song = new(name, artist, year);

            List<SongInfo> newSongs = new List<SongInfo>(bestSongs) { song };

            bestSongs = newSongs.ToArray();
        }

        public override IEnumerator GetIterator() => bestSongs.GetEnumerator();
    }
}