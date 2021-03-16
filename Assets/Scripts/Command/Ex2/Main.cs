using UnityEngine;

namespace Command.Ex2
{
    public class Main : MonoBehaviour
    {
        private void Start()
        {
            var device = DeviceCreator.GetTvDevice();

            DeviceOn(device);
            VolUp(device);
            VolUp(device);
            VolUp(device);
            VolUpUndo(device);
            VolDown(device);
            DeviceOff(device);

            device = DeviceCreator.GetRadioDevice();

            DeviceOn(device);
            VolUp(device);
            VolUp(device);
            VolUp(device);
            VolDown(device);
            VolDownUndo(device);
            DeviceOff(device);
        }

        private void DeviceOn(IElectronicDevice device)
        {
            var onCommand = new TurnDeviceOn(device);
            var onPressed = new DeviceButton(onCommand);
            onPressed.Press();
            Debug.Log($"{device.Name} is On now");
        }

        private void DeviceOff(IElectronicDevice device)
        {
            var offCommand = new TurnDeviceOff(device);
            var onPressed = new DeviceButton(offCommand);
            onPressed.Press();
            Debug.Log($"{device.Name} is Off now");
        }

        private void VolUp(IElectronicDevice device)
        {
            var volUp = new TurnVolumeUp(device);
            var onPressed = new DeviceButton(volUp);
            onPressed.Press();

            Debug.Log($"{device.Name} is vol Up now. Volume : {device.Vol}");
        }

        private void VolDown(IElectronicDevice device)
        {
            var volDown = new TurnVolumeDown(device);
            var onPressed = new DeviceButton(volDown);
            onPressed.Press();

            Debug.Log($"{device.Name} is vol Down now. Volume : {device.Vol}");
        }
        
        private void VolUpUndo(IElectronicDevice device)
        {
            var volUp = new TurnVolumeUp(device);
            var onPressed = new DeviceButton(volUp);
            onPressed.PressUndo();

            Debug.Log($"{device.Name} is vol Up Undo now. Volume : {device.Vol}");
        }

        private void VolDownUndo(IElectronicDevice device)
        {
            var volDown = new TurnVolumeDown(device);
            var onPressed = new DeviceButton(volDown);
            onPressed.PressUndo();

            Debug.Log($"{device.Name} is vol Down Undo now. Volume : {device.Vol}");
        }
    }
}
