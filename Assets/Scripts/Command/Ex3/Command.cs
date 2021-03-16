namespace Command.Ex3
{
    public abstract class Command
    {
        protected RemoteControlDevice Device;

        protected Command(RemoteControlDevice device)
        {
            Device = device;
        }

        public abstract void Execute();
    }
}