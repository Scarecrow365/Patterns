namespace Command.Ex2
{
    public class TurnVolumeUp : ICommand
    {
        private readonly IElectronicDevice _device;

        public TurnVolumeUp(IElectronicDevice device)
        {
            _device = device;
        }

        public void Execute()
        {
            _device.VolumeUp();
        }

        public void Undo()
        {
            _device.VolumeDown();
        }
    }
}