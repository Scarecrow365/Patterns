namespace Facade.Ex3
{
    public class BankAccountFacade
    {
        private readonly int _accountNumber;
        private readonly int _securityCode;

        private readonly AccountNumberCheck _accountNumberCheck;
        private readonly SecurityCodeCheck _securityCodeCheck;
        private readonly FundsCheck _fundsCheck;
        private readonly WelcomeToBank _welcomeToBank;

        public BankAccountFacade(int accountNumber, int newSecurityCode)
        {
            _accountNumber = accountNumber;
            _securityCode = newSecurityCode;

            _accountNumberCheck = new AccountNumberCheck();
            _securityCodeCheck = new SecurityCodeCheck();
            _fundsCheck = new FundsCheck();
            _welcomeToBank = new WelcomeToBank();

            _welcomeToBank.Hello();
        }

        public int GetAccountNumber()
        {
            return _accountNumber;
        }

        public int GetSecurityCode()
        {
            return _securityCode;
        }

        public string WithdrawCash(double cash)
        {
            if (_accountNumberCheck.AccountActive(_accountNumber)
            && _securityCodeCheck.IsCodeCorrect(_securityCode)
            && _fundsCheck.HaveEnoughMoney(cash))
            {
                _fundsCheck.WithdrawMoney(cash);
                return "Success";
            }
            else
            {
                return "Check your pin code";
            }
        }

        public string DepositCash(double cash)
        {
            if (_accountNumberCheck.AccountActive(_accountNumber)
                && _securityCodeCheck.IsCodeCorrect(_securityCode))
            {
                _fundsCheck.MakeDeposit(cash);
                return "Success";
            }
            else
            {
                return "Check your pin code";
            }
        }
    }
}