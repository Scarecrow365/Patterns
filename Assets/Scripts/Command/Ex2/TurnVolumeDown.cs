namespace Command.Ex2
{
    public class TurnVolumeDown : ICommand
    {
        private readonly IElectronicDevice _device;

        public TurnVolumeDown(IElectronicDevice device)
        {
            _device = device;
        }

        public void Execute()
        {
            _device.VolumeDown();
        }

        public void Undo()
        {
            _device.VolumeUp();
        }
    }
}