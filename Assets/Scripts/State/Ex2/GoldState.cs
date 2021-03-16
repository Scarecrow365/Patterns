namespace State.Ex2
{
    public class GoldState : State
    {
        public GoldState(State state) : this(state.GetBalance, state.GetAccount)
        {
        }

        public GoldState(double balance, Account account)
        {
            Balance = balance;
            Account = account;
            Initialize();
        }

        private void Initialize()
        {
        }

        public override void Deposit(double amount)
        {
            
        }

        public override void Withdraw(double amount)
        {
        }

        public override void PayInterest()
        {
        }
    }
}