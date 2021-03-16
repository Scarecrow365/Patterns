namespace State.Ex2
{
    public class SilverState : State
    {
        public SilverState(State state) : this(state.GetBalance, state.GetAccount)
        {
        }

        public SilverState(double balance, Account account)
        {
            Balance = balance;
            Account = account;
            Initialize();
        }

        private void Initialize()
        {
            Interest = 0.0;
            LowerLimit = 0.0;
            UpperLimit = 1000.0;
        }

        public override void Deposit(double amount)
        {
            Balance += amount;
            StateChangeCheck();
        }

        public override void Withdraw(double amount)
        {
            Balance -= amount;
            StateChangeCheck();
        }

        public override void PayInterest()
        {
            Balance += Interest * Balance;
            StateChangeCheck();
        }

        private void StateChangeCheck()
        {
            if (Balance < LowerLimit)
            {
                Account.CurrentState = new RedState(this);
            }
            else if (Balance > UpperLimit)
            {
                Account.CurrentState = new GoldState(this);
            }
        }
    }
}