namespace Strategy.Ex4
{
    public class Torpedo : Missile
    {
        public Torpedo()
        {
            seekBehavior = new SeekWithSonar();
        }
    }
}