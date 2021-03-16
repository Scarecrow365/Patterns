namespace Facade.Ex3
{
    public class SecurityCodeCheck
    {
        private int SecurityCode { get; } = 1234;

        public bool IsCodeCorrect(int code)
        {
            return SecurityCode == code;
        }
    }
}