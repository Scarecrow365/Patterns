namespace Command.Ex2
{
    public class DeviceCreator
    {
        public static IElectronicDevice GetTvDevice()
        {
            return new Television();
        }

        public static IElectronicDevice GetRadioDevice()
        {
            return new Radio();
        }
    }
}