namespace Command.Ex3
{
    public class KillSwitchCommand: Command
    {
        private RemoteControlDevice[] _devices;
        private static RemoteControlDevice _receiver;

        public KillSwitchCommand(RemoteControlDevice[] devices) : base(_receiver)
        {
            _devices = devices;
        }

        public override void Execute()
        {
            foreach (var device in _devices)
            {
                device.TurnOff();
            }
        }
    }
}