namespace Strategy.Ex4
{
    public class Tomahawk : Missile
    {
        public Tomahawk()
        {
            seekBehavior = new SeekWithGps();
        }
    }
}