namespace Command.Ex3
{
    public class TurnOnCommand : Command
    {
        public TurnOnCommand(RemoteControlDevice device) : base(device)
        {
        }

        public override void Execute()
        {
            Device.TurnOn();
        }
    }
}