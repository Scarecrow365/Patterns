namespace Strategy.Ex4
{
    public class SideWinder : Missile
    {
        public SideWinder()
        {
            seekBehavior = new SeekWithHeat();
        }
    }
}