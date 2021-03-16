namespace Command.Ex2
{
    public class TurnDeviceOff : ICommand
    {
        private readonly IElectronicDevice _device;

        public TurnDeviceOff(IElectronicDevice device)
        {
            _device = device;
        }

        public void Execute()
        {
            _device.Off();
        }

        public void Undo()
        {
            _device.On();
        }
    }
}