namespace State.Ex2
{
    public class Account
    {
        private State _state;
        public string Owner { get; }
        public double Balance => _state.GetBalance;

        public State CurrentState
        {
            get => _state;
            set => _state = value;
        }

        public Account(string owner)
        {
            Owner = owner;
            _state = new SilverState(0.0, this);
        }

        public void Deposit(double amount)
        {
            _state.Deposit(amount);
        }

        public void Withdraw(double amount)
        {
            _state.Withdraw(amount);
        }

        public void PayInterest()
        {
            _state.PayInterest();
        }
    }
}