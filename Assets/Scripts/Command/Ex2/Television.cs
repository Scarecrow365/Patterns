namespace Command.Ex2
{
    internal class Television : IElectronicDevice
    {
        public int Vol { get; private set; }
        public string Name => "Tv";

        public void On()
        {
        }

        public void Off()
        {
        }

        public void VolumeUp()
        {
            ++Vol;
        }

        public void VolumeDown()
        {
            --Vol;
        }
    }
}