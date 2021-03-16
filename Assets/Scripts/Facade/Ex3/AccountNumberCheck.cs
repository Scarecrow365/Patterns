namespace Facade.Ex3
{
    public class AccountNumberCheck
    {
        public int GetAccountNumber { get; } = 0987;

        public bool AccountActive(int accNumber)
        {
            return GetAccountNumber == accNumber;
        }
    }
}