namespace State.Ex2
{
    public abstract class State
    {
        protected Account Account;
        protected double Balance;

        protected double Interest;
        protected double LowerLimit;
        protected double UpperLimit;

        public Account GetAccount
        {
            get => Account;
            set => Account = value;
        }
        
        public double GetBalance
        {
            get => Balance;
            set => Balance = value;
        }

        public abstract void Deposit(double amount);
        public abstract void Withdraw(double amount);
        public abstract void PayInterest();
    }
}
