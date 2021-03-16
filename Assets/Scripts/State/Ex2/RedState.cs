namespace State.Ex2
{
    public class RedState : State
    {
        private double _serviceFee;

        public RedState(State state)
        {
            Balance = state.GetBalance;
            Account = state.GetAccount;
            Initialize();
        }

        private void Initialize()
        {
            Interest = 0;
            LowerLimit = -100;
            UpperLimit = 0;
            _serviceFee = 15;
        }


        public override void Deposit(double amount)
        {
            Balance += amount;
            StateChangeCheck();
        }

        public override void Withdraw(double amount)
        {
            Balance = amount - _serviceFee;
        }

        public override void PayInterest()
        {

        }

        private void StateChangeCheck()
        {
            if (Balance > UpperLimit)
            {
                Account.CurrentState = new SilverState(this);
            }
        }
    }
}