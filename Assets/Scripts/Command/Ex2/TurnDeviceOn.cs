namespace Command.Ex2
{
    public class TurnDeviceOn : ICommand
    {
        private readonly IElectronicDevice _device;

        public TurnDeviceOn(IElectronicDevice device)
        {
            _device = device;
        }

        public void Execute()
        {
            _device.On();
        }

        public void Undo()
        {
            _device.Off();
        }
    }
}