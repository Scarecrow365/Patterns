using System.Collections.Generic;

namespace Command.Ex2
{
    public class TurnItAllOff : ICommand
    {
        private readonly List<IElectronicDevice> _devices;

        public TurnItAllOff(List<IElectronicDevice> devices)
        {
            _devices = devices;
        }

        public void Execute()
        {
            foreach (var device in _devices)
            {
                device.Off();
            }
        }

        public void Undo()
        {
            foreach (var device in _devices)
            {
                device.On();
            }
        }
    }
}