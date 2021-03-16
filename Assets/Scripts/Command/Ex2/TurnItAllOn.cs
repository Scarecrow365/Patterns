using System.Collections.Generic;

namespace Command.Ex2
{
    public class TurnItAllOn : ICommand
    {
        private readonly List<IElectronicDevice> _devices;

        public TurnItAllOn(List<IElectronicDevice> devices)
        {
            _devices = devices;
        }

        public void Execute()
        {
            foreach (var device in _devices)
            {
                device.On();
            }
        }

        public void Undo()
        {
            foreach (var device in _devices)
            {
                device.Off();
            }
        }
    }
}