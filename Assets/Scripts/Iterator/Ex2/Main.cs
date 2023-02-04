using System.Collections;
using UnityEngine;

namespace Iterator.Ex2
{
    public class Main : MonoBehaviour
    {
        private void Start()
        {
            SongsOfTime song70s = new SongsOfThe70s();
            song70s.AddSong("song title", "song artist", 1974);
            song70s.AddSong("song title2", "song artist2", 1978);

            SongsOfTime song80s = new SongsOfThe80s();
            song80s.AddSong("song title 80s", "song artist 80s", 1985);
            song80s.AddSong("song title2 80s", "song artist2 80s", 1989);

            Iterate(song70s);
            Iterate(song80s);
        }

        private static void Iterate(SongsOfTime songsCollection)
        {
            IEnumerator iterator = songsCollection.GetIterator();
            while (iterator.MoveNext())
            {
                SongInfo info = (SongInfo)iterator.Current;
                
                if (info != null) 
                    Debug.Log(songsCollection.CollectionName + info.ToStringEx());
            }
        }
    }
}