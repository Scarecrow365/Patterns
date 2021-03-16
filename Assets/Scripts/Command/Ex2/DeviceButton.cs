namespace Command.Ex2
{
    public class DeviceButton
    {
        private readonly ICommand _cmd;

        public DeviceButton(ICommand newCmd)
        {
            _cmd = newCmd;
        }

        public void Press()
        {
            _cmd.Execute();
        }

        public void PressUndo()
        {
            _cmd.Undo();
        }
    }
}