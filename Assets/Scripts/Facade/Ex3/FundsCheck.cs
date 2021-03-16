namespace Facade.Ex3
{
    public class FundsCheck
    {
        public double CashInAccount { get; private set; } = 19999.00;

        protected void IncreaseCashInAccount(double cash)
        {
            CashInAccount += cash;
        }
        protected void DecreaseCashInAccount(double cash)
        {
            CashInAccount -= cash;
        }

        public bool HaveEnoughMoney(double cashToWithdraw)
        {
            return (cashToWithdraw > CashInAccount);
        }

        public void MakeDeposit(double cash)
        {
            IncreaseCashInAccount(cash);
        }

        public void WithdrawMoney(double cash)
        {
            DecreaseCashInAccount(cash);
        }
    }
}