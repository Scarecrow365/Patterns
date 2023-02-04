namespace Iterator.Ex2
{
    public class SongInfo
    {
        private string SongName { get; }
        private string BandName { get; }
        private int YearReleased { get; }

        public SongInfo(string songName, string bandName, int yearReleased)
        {
            SongName = songName;
            BandName = bandName;
            YearReleased = yearReleased;
        }

        public string ToStringEx() => $"{SongName} - {BandName} : {YearReleased}";
    }
}