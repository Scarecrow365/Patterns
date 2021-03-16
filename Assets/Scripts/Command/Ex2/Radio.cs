namespace Command.Ex2
{
    public class Radio : IElectronicDevice
    {
        public int Vol { get; private set; }
        public string Name => "Radio";

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