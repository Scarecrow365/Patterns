using System.Collections.Generic;

namespace Observer.Ex1
{
    public class Stock
    {
        private double _price;
        private readonly List<IInvestor> _investors = new List<IInvestor>();

        public string Symbol { get; }

        public double Price
        {
            get => _price;
            set
            {
                if (_price == value) return;
                _price = value;
                Notify();
            }
        }

        public Stock(string symbol, double price)
        {
            Symbol = symbol;
            _price = price;
        }

        public void Attach(IInvestor investor)
        {
            _investors.Add(investor);
        }

        public void Detach(IInvestor investor)
        {
            _investors.Remove(investor);
        }

        public void Notify()
        {
            foreach (var investor in _investors)
            {
                investor.Update(this);
            }
        }
    }
}
