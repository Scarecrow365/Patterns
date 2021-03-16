using UnityEngine;

namespace Command.Ex3
{
    public class Main : MonoBehaviour
    {
        private RemoteControlDevice _device;

        private void Start()
        {
            _device = new RadioReceiver();

            var command = new TurnOnCommand(_device);
            var invoker = new Invoker();
            invoker.SetCommand(command);

            invoker.ExecuteCommand();
        }
    }
}