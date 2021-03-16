namespace Command.Ex2
{
    public interface IElectronicDevice
    {
        public int Vol { get; }
        public string Name { get; }


        void On();
        void Off();
        void VolumeUp();
        void VolumeDown();
    }
}