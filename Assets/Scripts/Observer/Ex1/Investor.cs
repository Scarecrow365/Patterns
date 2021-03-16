namespace Observer.Ex1
{
    public class Investor : IInvestor
    {
        private string _name;

        public Stock MyStock { get; set; }

        public Investor(string name)
        {
            _name = name;
        }

        public void Update(Stock stock)
        {

        }
    }
}